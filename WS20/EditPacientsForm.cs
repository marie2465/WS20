using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS20
{
    public partial class EditPacientsForm : Form
    {
        private static EditPacientsForm instance;
        public static EditPacientsForm getInstance(string name)
        {
            if(instance==null)
            {
                instance = new EditPacientsForm(name);
            }
            return instance;
        }
        private static void NullInstance()
        {
            instance = null;
        }
        public EditPacientsForm(string name)
        {
            InitializeComponent();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                var com=from m in db.InsureCompany select m;
                foreach(var v in com)
                {
                    company.Items.Add(v.Name);
                }
                var pac = from a in db.Pacients
                          join b in db.InsureCompany on a.IdCompany equals b.ID
                          where a.FIO.Equals(name)
                          select new
                          {
                              FIO = a.FIO,
                              DateofBirth = a.Date_of_birth,
                              Email = a.Email,
                              Passport_data = a.Passport_data,
                              Phone = a.Phone,
                              Insure_policy = a.Insurance_policy,
                              Type_of_Policy = a.Type_of_policy,
                              NameCompany = b.Name
                          };
                foreach(var t in pac)
                {
                    string[] passp = t.Passport_data.Split(' ');
                    string seria = passp[0];
                    string number = passp[1];
                    namePacient.Text = t.FIO;
                    dateOfBirth.Value = t.DateofBirth;
                    seriaPassport.Text = seria;
                    numberPassport.Text = number;
                    telephone.Text = t.Phone.ToString();
                    e_mail.Text = t.Email;
                    numberPolicy.Text = t.Insure_policy.ToString();
                    typePolicy.Text = t.Type_of_Policy;
                    company.Text = t.NameCompany;
                }
            }
        }

        private void okay_Click(object sender, EventArgs e)
        {
            using (PoliclinicDB db = new PoliclinicDB())
            {
                var pacients = db.Pacients.Where(p => p.FIO.Equals(namePacient.Text)).FirstOrDefault();
                pacients.FIO = namePacient.Text;
                pacients.Date_of_birth = dateOfBirth.Value;
                pacients.Email = e_mail.Text;
                pacients.Insurance_policy = int.Parse(numberPolicy.Text);
                pacients.Passport_data = seriaPassport.Text + " " + numberPassport.Text;
                pacients.Phone = double.Parse(telephone.Text);
                pacients.Type_of_policy = typePolicy.Text;
                string companyName = company.Text;
                var test = from a in db.InsureCompany
                           where a.Name.Equals(companyName)
                           select a;
                foreach (var p in test)
                {
                    pacients.IdCompany = p.ID;
                }
                db.Entry(pacients).State =  EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Вы успешно изменили данные пациента");
            }
            this.Close();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPacientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullInstance();
        }
    }
}
