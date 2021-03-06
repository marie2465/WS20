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
    public partial class PrintingForm : Form
    {
        public PrintingForm(string shtr,List<string> list)
        {
            InitializeComponent();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                //загрузка из бд
                var querry = from a in db.Order
                             join b in db.Pacients on a.IdPacient equals b.ID
                             join c in db.Service on a.IdService equals c.ID
                             join d in db.SetService on c.SetServiceId equals d.Id
                             select new
                             {
                                 FIO = b.FIO,
                                 Barcode = a.Bacode,
                                 ServiceSet = a.IdSetService,
                                 servicesId=a.IdService,
                                 NumberPolicy = b.Insurance_policy,
                                 DateOfBirth = b.Date_of_birth,
                                 Cost = c.Cost,
                                 SetServices=d.Id,
                                 IdOrder=a.ID
                             };
                double costs = 0;
                foreach(var posts in querry)
                {
                    namesPacients.Text = posts.FIO;
                    dateOfBirth.Text = posts.DateOfBirth.ToString();
                    insurePolicy.Text = posts.NumberPolicy.ToString();
                    barcode.Text = shtr;
                    numberOrder.Text = posts.IdOrder.ToString();
                    dateOrder.Text = DateTime.Now.ToString();
                }
                foreach (var p in list)
                {
                    servicesSet.Items.Add(p);
                }
                var listC = list.Distinct();
                foreach (var t in listC)
                {
                    for (int i = 1; i <= servicesSet.Items.Count; i++)
                    {
                        Service service = db.Service.Where(k => k.Name.Equals(t)).FirstOrDefault();
                        costs += service.Cost;
                        cost.Text = costs.ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        //печать старницы
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int width = this.panel1.Width;
            int heigth = this.panel1.Height;
            Bitmap bmp = new Bitmap(width, heigth);
            this.panel1.DrawToBitmap(bmp, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage((Image)bmp, 10, 10);
        }
    }
}
