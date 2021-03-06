using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WS20.Model;

namespace WS20
{
    public partial class AnalyzeForm : Form
    {
        int ids = 0;
        public AnalyzeForm(int id)
        {
            InitializeComponent();
            ids = id;
            using(PoliclinicDB db=new PoliclinicDB())
            {
                //получение данных
                var querry = from a in db.Order
                             join b in db.Service on a.IdService equals b.ID
                             join c in db.Biomaterial on a.BiomaterialId equals c.IdBiomaterial
                             where a.ID == id
                             select new
                             {
                                 NameServ = b.Name,
                                 Cost = b.Cost,
                                 BiomaterialName = c.NameBiomaterial
                             };
                foreach(var t in querry)
                {
                    nameService.Text = t.NameServ;
                    cost.Text = t.Cost.ToString();
                    biomaterial.Text = t.BiomaterialName;
                }
            }
        }

        //работа c json (запись) serelization
        private void okay_Click(object sender, EventArgs e)
        {
            using (PoliclinicDB db = new PoliclinicDB())
            {
                var ordersData = from a in db.Order
                                 where a.ID == ids
                                 select a;
                foreach (var o in ordersData)
                {
                    
                    string json = "https://localhost:44323/api/orders";
                    StreamWriter st = null;
                    string posts = (@"{id=" + o.ID 
                        + ";idPacient=" + o.IdPacient 
                        + ";idSetService=" + o.IdSetService 
                        + ";status=" + @"""OK""" + ";bacode=" 
                        + o.Bacode + ";idService=" + o.IdService 
                        + ";biomaterialId=" + o.BiomaterialId + "}");
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(json);
                    req.Method = "POST";
                    req.ContentLength = posts.Length;
                    req.ContentType = "application/json; charset=utf-8";
                    st = new StreamWriter(req.GetRequestStream());
                    byte[] sendBuffer = Encoding.UTF8.GetBytes(posts);
                    st.Write(posts);
                    st.Close();

                    HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                    StreamReader srData = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                    string outHtml = srData.ReadToEnd();
                    MessageBox.Show(outHtml);
                    resp.Close();
                    srData.Close();
                    
                    //using (var ms=new MemoryStream(Encoding.Unicode.GetBytes(json)))
                    //{
                    //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Services));
                    //    Services services = new Services();
                    //    serializer.WriteObject(ms, services);
                    //    byte[] array = ms.ToArray();
                    //    ms.Close();
                    //    Encoding.UTF8.GetString(array, 0, array.Length);
                    //}
                }
            }
        }
    }
}
