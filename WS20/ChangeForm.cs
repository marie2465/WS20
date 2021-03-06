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
    public partial class ChangeForm : Form
    {
        string companiesName;
        public ChangeForm(string nameCompany)
        {
            InitializeComponent();
            companiesName = nameCompany;
        }

        private void pdf_file_Click(object sender, EventArgs e)
        {
            PrintinigScoreForm printinigScore = new PrintinigScoreForm(companiesName);
            printinigScore.Show();
            this.Close();
        }

        private void csv_file_Click(object sender, EventArgs e)
        {
            CsvScoreForm csvScoreForm = new CsvScoreForm(companiesName);
            csvScoreForm.Show();
            this.Close();
        }
    }
}
