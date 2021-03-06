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
    public partial class AddPacientForm : Form
    {
        public AddPacientForm()
        {
            InitializeComponent();
            //загрузка компонентов
            using(PoliclinicDB db = new PoliclinicDB())
            {
                var query = from a in db.InsureCompany
                            select a;
                foreach(var t in query)
                {
                    company.Items.Add(t.Name);
                }
            }
            Login.Enabled = false;
            passw.Enabled = false;
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //кнопка добавление в бд
        private void okay_Click(object sender, EventArgs e)
        {
            using(PoliclinicDB db = new PoliclinicDB())
            {
                Pacients pacients = new Pacients();
                pacients.Login = Login.Text;
                pacients.Password = passw.Text;
                pacients.FIO = namePacient.Text;
                pacients.Date_of_birth = dateOfBirth.Value;
                pacients.Email = e_mail.Text;
                pacients.Passport_data = seriaPassport.Text + " " + numberPassport.Text;
                pacients.Phone = double.Parse(telephone.Text);
                pacients.Insurance_policy = 8 + int.Parse(numberPolicy.Text);
                pacients.Type_of_policy = typePolicy.Text;
                string companyName = company.Text;
                var test = from a in db.InsureCompany
                           where a.Name.Equals(companyName)
                           select a;
                foreach(var p in test)
                {
                    pacients.IdCompany = p.ID;
                }
                db.Pacients.Add(pacients);
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
