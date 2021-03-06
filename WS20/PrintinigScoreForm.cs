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
    public partial class PrintinigScoreForm : Form
    {
        public PrintinigScoreForm(string nameCompany)
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
                    
                    namesPacients.Text += h.NamePac + " - " + serv + Environment.NewLine;
                    namesPacients.SizeChanged += new EventHandler(this.namesPacients_TextChanged);
                    serv = "";
                    CostService.Items.Add(h.NamePac + " - " + cena);
                    cena = 0;
                }

                foreach (var p in post)
                {
                    insureCompany.Text = p.NameCompany;
                    periodCost.Text = p.PeriodCost.ToString();
                }
            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.printDocument1_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = doc;
            if(printDialog.ShowDialog()==DialogResult.OK)
            {
                doc.Print();
                
            }
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int width = panel1.Width;
            int height = panel1.Height;
            Bitmap bitmap = new Bitmap(width, height);
            this.panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));
            e.Graphics.DrawImage((Image)bitmap, 10, 10);
        }

        private void namesPacients_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
