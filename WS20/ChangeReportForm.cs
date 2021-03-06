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
    public partial class ChangeReportForm : Form
    {
        private static ChangeReportForm instance;
        private static ChangeReportForm getInstance ()
        {
            if(instance==null)
            {
                instance = new ChangeReportForm();
            }
            return instance;
        }

        private static void NullInstance()
        {
            instance = null;
        }

        public ChangeReportForm()
        {
            InitializeComponent();
        }

        private void ChangeReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullInstance();
        }

        private void reportTable_Click(object sender, EventArgs e)
        {
            ReportServicesForm reportServicesForm = new ReportServicesForm();
            reportServicesForm.Show();
        }

        private void chartReport_Click(object sender, EventArgs e)
        {
            ReportchartSForm reportchart = new ReportchartSForm();
            reportchart.Show();
        }
    }
}
