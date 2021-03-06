using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

using System.Windows.Forms;
using WS20.Model;

namespace WS20
{
    public partial class ServicesForm : Form
    {
        

        public ServicesForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                var querry = from a in db.Order
                             join b in db.Service on a.IdService equals b.ID
                             where a.Status.Equals("OK") || a.Status.Equals("IN PROGRESS")
                             select new
                             {
                                 ID = a.ID,
                                 NameServices = b.Name,
                                 Status = a.Status,
                                 Cost = b.Cost
                             };
                int i = 0;
                foreach(var u in querry)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = u.ID;
                    dataGridView1[1, i].Value = u.NameServices;
                    dataGridView1[2, i].Value = u.Status;
                    dataGridView1[3, i].Value = u.Cost;
                    i++;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = null;
            if (e.ColumnIndex == 4)
            {
                string nameServ = dataGridView1[1, e.RowIndex].Value.ToString();
                int id = int.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
                string status = dataGridView1[2, e.RowIndex].Value.ToString();
               
                if (status.Equals("OK"))
                {
                    //открытие формы с выбором анализатора
                    AnalyzeForm analyzeForm = new AnalyzeForm(id);
                    //диалоговым окном
                    if (analyzeForm.ShowDialog() == DialogResult.Cancel) return;
                    //изменения в бд
                    using (PoliclinicDB db = new PoliclinicDB())
                    {
                        Order order = db.Order.Where(p => p.ID == id).FirstOrDefault();
                        order.Status = "IN PROGRESS";
                        db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else if (status.Equals("IN PROGRESS"))//работа с json (чтение) deserelezatio
                {
                    
                    //получение данных
                    using (PoliclinicDB db = new PoliclinicDB())
                    {
                        var orderName = from o in db.Order
                                        join a in db.Service on o.IdService equals a.ID
                                        where o.ID.Equals(id)
                                        select o;
                        foreach (var t in orderName)
                        {
                            var pacinties = from a in db.Pacients
                                            where a.ID == t.ID
                                            select a;
                            foreach (var p in pacinties)
                            {
                                string json = "https://localhost:44323/api/orders/" + p.FIO;
                                FromJson(json);
                            }
                        }
                    }
                }
            }
        }

        public void FromJson(string json)
        { 
            HttpWebRequest listener = (HttpWebRequest)HttpWebRequest.Create(json);
            HttpWebResponse webResponse = (HttpWebResponse)listener.GetResponse();
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
            string text = streamReader.ReadToEnd();
            webResponse.Close();
            streamReader.Close();
            string[] mas = text.Split(',');
            string[] Pacient = mas[0].Split(':');
            int pacient = int.Parse(Pacient[1]);
            string[] services = mas[1].Split(':');
            string n1 = services[2].Substring(0,1)+", ";
            for (int i=2; i<mas.Count(); i++)
            {
                string[] number = mas[i].Split(':');
                n1 += number[1].Substring(0,1)+", ";
            }
            textBox1.Text += "Idpacient: " + pacient + "  IdServices: " + n1;
        }
    }
}