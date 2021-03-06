using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS20
{
    public partial class CsvScoreForm : Form
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        public CsvScoreForm(string nameCompany)
        {
            InitializeComponent();
            using (PoliclinicDB db = new PoliclinicDB())
            {
                var post = from a in db.InsureCompany
                           join b in db.Pacients on a.ID equals b.IdCompany
                           join c in db.Order on b.ID equals c.IdPacient
                           join d in db.Service on c.IdService equals d.ID
                           where a.Name.Equals(nameCompany)
                           select new
                           {
                               NameCompany = a.Name,
                               PeriodCost = d.Period,
                               NamePacients = b.FIO,
                               ServicesName = d.Name,
                               Cost = d.Cost
                           };
                var postPac = from a in db.Order
                              join b in db.Pacients on a.IdPacient equals b.ID
                              join d in db.Service on a.IdService equals d.ID
                              select new
                              {
                                  NamePacients = b.FIO,
                                  ServicesName = d.Name,
                                  Cost = d.Cost
                              };
                var namePac = from a in db.InsureCompany
                              join b in db.Pacients on a.ID equals b.IdCompany
                              where a.Name.Equals(nameCompany)
                              select new
                              {
                                  NamePac = b.FIO
                              };

                var list = namePac.ToList();
                string serv = "";
                double cena = 0;
                foreach (var h in list)
                {
                    foreach (var t in postPac)
                    {
                        if (h.NamePac.Equals(t.NamePacients))
                        {

                            serv += t.ServicesName + ", ";
                            cena += t.Cost;
                        }

                    }

                    namesPacients.Text += h.NamePac + " - " + serv + $"\n" + Environment.NewLine;
                    serv = "";
                    CostService.Text += h.NamePac + " - " + cena + $"\n" + Environment.NewLine;
                    cena = 0;
                }

                foreach (var p in post)
                {
                    insureCompany.Text = p.NameCompany;
                    periodCost.Text = p.PeriodCost.ToString();
                }
            }
            //в каком формате сохранять файл
            saveFileDialog.Filter = "Text files(*.csv)|*.csv|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //выгрузка csv-файла
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string newPath = saveFileDialog.FileName;
                    using (StreamWriter strw = File.AppendText(newPath))
                    {
                        strw.WriteLine(insureCompany.Text + ";" + periodCost.Text + ";" + namesPacients.Text + ";" + CostService.Text + $"\n");
                        MessageBox.Show("Файл успешно сохранен!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
