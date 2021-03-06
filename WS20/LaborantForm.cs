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
    public partial class LaborantForm : Form
    {
        public LaborantForm(string email)
        {
            InitializeComponent();

            using(PoliclinicDB db=new PoliclinicDB())
            {
                var query = from a in db.Users
                            where a.Login.Equals(email)
                            select a;
                foreach(var les in query)
                {
                    firstName.Text = les.FirstName;
                    name.Text = les.LastName;
                    login.Text = les.Login;
                    int date = DateTime.Now.Year;
                    int age = date - les.DateOfBirth.Year;
                    year.Text = age.ToString();
                    //загрузка картинки
                    try
                    {
                        string path = $"{Environment.CurrentDirectory}" + "\\photo\\" + les.Photo;
                        FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                        byte[] image = new byte[fileStream.Length];
                        fileStream.Read(image, 0, Convert.ToInt32(fileStream.Length));
                        pictureBox1.Image = Image.FromStream(fileStream);
                    }
                    catch(Exception e)
                    {

                    }
                }    
            }
        }

        private void biomaterial_Click(object sender, EventArgs e)
        {
            GetBioForm getBio = new GetBioForm(login.Text);
            getBio.Show();
        }

        private void report_Click(object sender, EventArgs e)
        {

        }
    }
}
