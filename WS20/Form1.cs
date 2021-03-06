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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autorization_Click(object sender, EventArgs e)
        {
            using (PoliclinicDB db = new PoliclinicDB())
            {
                if (login.Text.Length == 0 && password.Text.Length == 0)
                {
                    MessageBox.Show("Заполните все поля");
                }
                else if (login.Text.Length == 0 && password.Text.Length != 0)
                {
                    MessageBox.Show("Введите логин");
                }
                else if (login.Text.Length != 0 && password.Text.Length == 0)
                {
                    MessageBox.Show("Введите пароль");
                }
                else
                {
                    var quer = from a in db.Users
                               join b in db.Role on a.RoleID equals b.RoleId
                               where a.Login.Equals(login.Text) && a.Password.Equals(password.Text)
                               select new
                               {
                                   Login = a.Login,
                                   Password = a.Password,
                                   RoleId = a.RoleID
                               };

                    if (quer.Count() != 0)
                    {
                        foreach (var d in quer)
                        {
                            if (d.RoleId == 1)
                            {
                                LaborantForm personal = new LaborantForm(d.Login);
                                personal.Show();
                            }
                            else if (d.RoleId == 2)
                            {
                                LResearchForm lResercher = new LResearchForm(d.Login);
                                lResercher.Show();
                            }
                            else if (d.RoleId == 3)
                            {
                                BookerForm booker = new BookerForm(d.Login);
                                booker.Show();
                            }
                        }
                    }
                    else
                    {
                        using (PoliclinicDB dbr = new PoliclinicDB())
                        {
                            var Login = dbr.Users.FirstOrDefault(p => p.Login.Equals(login.Text));
                            var Pass = dbr.Users.FirstOrDefault(p => p.Password.Equals(password.Text));
                            if (Login == null && Pass != null)
                            {
                                MessageBox.Show("Неверно введен логин");
                            }
                            else if (Login != null && Pass == null)
                            {
                                MessageBox.Show("Неверно введен пароль");
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден");
                            }
                        }
                    }
                }
            }
        }
    }
}
