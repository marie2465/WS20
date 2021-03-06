using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS20
{
    public partial class ReportchartSForm : Form
    {
        private static ReportServicesForm instance;
        private static ReportServicesForm getInstance()
        {
            if (instance == null)
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
        public ReportchartSForm()
        {
            InitializeComponent();
        }

        private void ReportchartSForm_Load(object sender, EventArgs e)
        {

        }

        //работа с графиком
        private void repTable_Click(object sender, EventArgs e)
        {
            int i = 0;
            using (PoliclinicDB db = new PoliclinicDB())
            {
                DateTime dateFirst = startDate.Value;
                DateTime dateEnd = endDate.Value;
                var posts = from a in db.Order
                            where a.DataOrder >= dateFirst && a.DataOrder <= dateEnd
                            select a;

                var pac = from a in db.Order
                          where a.DataOrder >= dateFirst && a.DataOrder <= dateEnd
                          orderby a.DataOrder
                          select new
                          {
                              Period = a.DataOrder,
                              IdPacient = a.IdPacient
                          };
                var ser = from a in db.Order
                          where a.DataOrder >= dateFirst && a.DataOrder <= dateEnd
                          orderby a.DataOrder
                          select new
                          {
                              Period = a.DataOrder,
                              Idservices = a.IdService
                          };
                var setSer = from a in db.Order
                             where a.DataOrder >= dateFirst && a.DataOrder <= dateEnd
                             orderby a.DataOrder
                             select new
                             {
                                 Period = a.DataOrder,
                                 IdSetService = a.IdSetService
                             };
                foreach (var y in posts)
                {
                    if (y.DataOrder >= dateFirst && y.DataOrder <= dateEnd)
                    {
                        int serv = int.Parse(y.IdService.ToString());
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

                int date1 = startDate.Value.Day;
                int date2 = endDate.Value.Day;
                int datesub = date2 - date1;
                int nPac = int.Parse(pacien.Text);
                float coun = nPac / datesub;
                averagePac.Text = coun.ToString();
                int clPac = 0;
                //chart построение пациентов
                foreach (var u in posts)
                {
                    foreach (var t in pac)
                    {
                        if (t.Period.Equals(u.DataOrder))
                        {
                            clPac++;
                        }
                        int sat = clPac;
                        chart1.Series[0].Points.AddXY(u.DataOrder, sat);
                        clPac = 0;
                    }
                }
                //chart построение услуг
                int clSer = 0;
                foreach (var y in posts)
                {
                    foreach (var t in ser)
                    {
                        if (t.Period.Equals(y.DataOrder))
                        {
                            clSer++;
                        }
                    }
                    int sat = clSer;
                    chart1.Series[1].Points.AddXY(y.DataOrder, sat);
                    clSer = 0;
                }
                //chart построение перечня услуг
                int clSetSer = 0;
                foreach (var y in posts)
                {
                    foreach (var t in setSer)
                    {
                        if (t.Period.Equals(y.DataOrder))
                        {
                            clSetSer++;
                        }
                    }
                    int sat = clSetSer;
                    chart1.Series[2].Points.AddXY(y.DataOrder, sat);
                    clSetSer = 0;
                }
            }
        }

        private void ReportchartSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullInstance();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //печать
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.printDocument1_PrintPage;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                doc.Print();
            }

        }

        //печать страницы
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //Bitmap bitmap = new Bitmap();
        }
    }
}
