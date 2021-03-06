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
    public partial class LResearchForm : Form
    {
        public LResearchForm(string email)
        {
            InitializeComponent();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                var querry = from a in db.Users
                             where a.Login.Equals(email)
                             select a;
                foreach(var l in querry)
                {
                    firstName.Text = l.FirstName;
                    name.Text = l.LastName;
                    login.Text = l.Login;
                    int a = DateTime.Now.Year;
                    int age = a - l.DateOfBirth.Year;
                    year.Text = age.ToString();
                    //загрузка картинки
                    try
                    {
                        string path = $"{Environment.CurrentDirectory}" + "\\photo\\" + l.Photo;
                        FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                        byte[] image = new byte[file.Length];
                        file.Read(image, 0, Convert.ToInt32(file.Length));
                        pictureBox1.Image = Image.FromStream(file);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Работа программы приостановлена");
                    }
                }
            }
        }

        private void biomaterial_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }
    }
}
