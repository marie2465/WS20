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
    public partial class BookerForm : Form
    {
        //открытие одиночного окна
        private static BookerForm instance;
        private static BookerForm getInstance(string email)
        {
            if(instance==null)
            {
                instance = new BookerForm(email);
            }
            return instance;
        }
        //обнуление
        private static void NullInstance()
        {
            instance = null;
        }

        public BookerForm(string email)
        {
            InitializeComponent();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                var first = from a in db.Users
                            where a.Login.Equals(email)
                            select a;
                foreach(var high in first)
                {
                    firstName.Text = high.FirstName;
                    name.Text = high.LastName;
                    login.Text = high.Login;
                    int a = DateTime.Now.Year;
                    int date = a - high.DateOfBirth.Year;
                    year.Text = date.ToString();
                    //загрузка картинки
                    try
                    {

                    }
                    catch(Exception e)
                    {

                    }
                }
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            ChangeReportForm scoreForm = new ChangeReportForm();
            scoreForm.Show();
        }

        private void BookerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullInstance();
        }

        private void biomaterial_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.Show();
        }
    }
}
