using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS20
{
    public partial class ReportServicesForm : Form
    {
        private static ReportServicesForm instance;
        private static ReportServicesForm getInstance()
        {
            if(instance==null)
            {
                instance = new ReportServicesForm();
            }
            return instance;
        }
        private void NullInstance()
        {
            instance = null;
        }
        int x = 0;
        int n = 0;
        public ReportServicesForm()
        {
            InitializeComponent();
            
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportServicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullInstance();
        }
        //получение данных
        private void repTable_Click(object sender, EventArgs e)
        {

            using (PoliclinicDB db = new PoliclinicDB())
            {
                DateTime dateFirst = startDate.Value;
                DateTime dateEnd = endDate.Value;
                int i = 0;
                var dates = db.Order.Where(p => p.DataOrder >= dateFirst && p.DataOrder <= dateEnd).GroupBy(p => p.DataOrder).ToList();
                var pacients = db.Order.Where(p => p.DataOrder >= dateFirst && p.DataOrder <= dateEnd).OrderBy(o => o.DataOrder).GroupBy(p => p.IdPacient).ToList();
                var setsServices = db.Order.Where(p => p.DataOrder >= dateFirst && p.DataOrder <= dateEnd).GroupBy(p => p.IdSetService).ToList();
                foreach (var b in dates)
                {

                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = b.Key.Value.Date;
                    dataGridView1[1, i].Value = b.Count();
                    foreach (var c in setsServices)
                    {
                        dataGridView1[2, i].Value = c.Count();
                    }
                    foreach (var t in pacients)
                    {
                        dataGridView1[3, i].Value = t.Count();
                    }
                    i++;
                }

                //все количество
                var posts = from a in db.Order
                            where a.DataOrder >= dateFirst && a.DataOrder <= dateEnd
                            orderby a.DataOrder
                            select a;
                var pac = from a in db.Order
                          where a.DataOrder >= dateFirst && a.DataOrder <= dateEnd
                          orderby a.DataOrder
                          select new
                          {
                              Period = a.DataOrder,
                              IdPacient = a.IdPacient
                          };

                foreach (var y in posts)
                {
                    if (y.DataOrder >= dateFirst && y.DataOrder <= dateEnd)
                    {
                        int serv = int.Parse(y.IdPacient.ToString());
                        x += serv;
                        servicesCount.Text = x.ToString();
                    }
                }
                x = 0;
                foreach (var t in posts)
                {
                    if (t.DataOrder >= dateFirst && t.DataOrder <= dateEnd)
                    {
                        int setServ = db.SetService.Where(k => k.Id.Equals(t.IdSetService)).ToList().Count;
                        n += setServ;
                        setService.Text = n.ToString();
                    }
                }
                n = 0;
                foreach (var t in pac.Distinct())
                {
                    if (t.Period >= dateFirst && t.Period <= dateEnd)
                    {
                        int setServ = db.Pacients.Where(k => k.ID.Equals(t.IdPacient)).ToList().Count;
                        n += setServ;
                        if (n != 0)
                        {
                            pacien.Text = n.ToString();
                        }
                        else
                        {
                            pacien.Text = "0";
                        }
                    }
                }
            }
        }
    }
}