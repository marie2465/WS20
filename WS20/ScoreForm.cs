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
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                var querry = from a in db.InsureCompany
                             select a;
                foreach(var j in querry)
                {
                    company.Items.Add(j.Name);
                }
            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            string name = company.Text;
            ChangeForm printinigScore = new ChangeForm(name);
            printinigScore.Show();
        }
        
        //изменение
        private void company_TextChanged(object sender, EventArgs e)
        {
            string compnies = company.Text;
            string per = period.Value.ToString();
            namesPacients.Items.Clear();
            CostService.Items.Clear();
            using(PoliclinicDB db=new PoliclinicDB())
            {
                if (per.Length != 0)
                {
                    var post = from a in db.InsureCompany
                               join b in db.Pacients on a.ID equals b.IdCompany
                               join c in db.Order on b.ID equals c.IdPacient
                               join d in db.Service on c.IdService equals d.ID
                               where a.Name.Equals(compnies)
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
                                  where a.Name.Equals(compnies)
                                  select new
                                  {
                                      NamePac = b.FIO
                                  };

                    var list = namePac.ToList();
                    string serv = "";
                    double cena = 0;
                    foreach (var h in list)
                    {
                        foreach(var t in postPac)
                        {
                            if(h.NamePac.Equals(t.NamePacients))
                            {
                                
                                serv += t.ServicesName + ", ";
                                cena += t.Cost;
                            }
                            
                        }
                        
                        namesPacients.Items.Add(h.NamePac + " - " + serv);
                        serv = "";
                        CostService.Items.Add(h.NamePac + " - " + cena);
                        cena = 0;
                    }

                    foreach(var p in post)
                    {
                        nameInsure.Text = p.NameCompany;
                        periodCost.Text = p.PeriodCost.ToString();
                    }
                }
            }
        }
    }
}
