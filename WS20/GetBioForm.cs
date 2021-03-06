using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
using System.Drawing.Printing;
using System.Runtime.Remoting.Messaging;

namespace WS20
{
    public partial class GetBioForm : Form
    {
        //открытие одиночного окна, без повторений
        private static GetBioForm instance;
        public static GetBioForm getInstance(string login)
        {
            if (instance == null)
            {
                instance = new GetBioForm(login);
            }
            return instance;
        }
        //обнуление
        private static void NullInstance()
        {
            instance = null;
        }

        float[] bars = new float[] { 2f, 2.5f, 3f, 3.5f, 4f, 4.5f, 5f, 5.5f, 6f, 6.5f, 7f };
        Bitmap bmp;
        private int Codezakaza;
        private Random rnd;
        string index;
        List<string> words = new List<string>();
        string emails;
        //static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        public GetBioForm(string login)
        {
            InitializeComponent();
            emails = login;
            namesPacients.Clear();
            string first = namesPacients.Text;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (PoliclinicDB db = new PoliclinicDB())
            {
                var quert = from a in db.Pacients
                            select a;
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                foreach (var t in quert)
                {
                    //if (LevenshteinDistance(t.FIO.Split(' ')[0], namesPacients.Text) <= 3)
                    //{
                        source.Add(t.FIO);
                    //}
                }
                namesPacients.AutoCompleteCustomSource = source;
                namesPacients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                namesPacients.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //var test = from a in db.Pacients
                //           select a;
                //foreach (var t in test)
                //{
                //    string second = t.FIO;
                //    words.Add(second);
                //}

                var date = from p in db.SetService
                           select p;
                foreach(var n in date)
                {
                    setdates.Items.Add(n.Name);
                }
                var setdate = from a in db.Biomaterial
                              select a;
                AutoCompleteStringCollection sourceBiomaterial = new AutoCompleteStringCollection();
                foreach (var e in setdate)
                {
                    sourceBiomaterial.Add(e.CodeBiomaterial.ToString() + " " + e.NameBiomaterial);
                }
                barcode.AutoCompleteCustomSource = sourceBiomaterial;
                barcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                barcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                pictureBox1.Image = bmp;
                checkedListBox1.Visible = false;
            }
        }

        private void ok_Click_1(object sender, EventArgs e)
        {
            string barcode = BarCodeGenerate();
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            SolidBrush myBrash = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.White);
            float space = 15;
            float x1 = 5, y1 = 5;
            float x2 = 5, y2 = 150;
            for (int i = 0; i < barcode.Length; i++)
            {
                Pen mypen = new Pen(Color.Black, bars[int.Parse(barcode[i].ToString())]);
                g.DrawLine(mypen, x1, y1, x2, y2);
                Font font = new Font("Arial", 8);
                g.DrawString(barcode[i].ToString(), font, myBrash, x2, y2 + 10);
                x1 += space;
                x2 += space;
            }
            pictureBox1.Invalidate();
            ean13Text.Text = barcode;
        }

        private void print_Click_1(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.printDocument1_PrintPage;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image,100,20);
        }

        //генерация штрихкода
        private string BarCodeGenerate()
        {
            rnd = new Random();
            Codezakaza = rnd.Next();
            long day = DateTime.Now.Millisecond;
            string prefiks = Codezakaza.ToString().Substring(0, 2);
            string shcode =prefiks.Length == 0?"40":prefiks + ("0000000000" + Codezakaza).Substring(("0000000000" + Codezakaza).Length -11);
            string strShk = shcode + GetControlEan(shcode);
            return strShk;
        }

        //генерация штрихкода последняя цифра
        private string GetControlEan(string str)
        {
            int ch = 0;
            int nch = 0;
            for(int i=1; i<6; i++)
            {
                ch += int.Parse(str.Substring(2 * i, 1));
                nch += int.Parse(str.Substring(2 * i - 1, 1));
            }
            ch *= 3;
            int cntr = 10 * (ch + nch) % 10;

            return cntr==10?"0":cntr.ToString();
        }

        //добавление
        private void add_Click(object sender, EventArgs e)
        {
            AddPacientForm addPacientForm = new AddPacientForm();
            addPacientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        
        //изменение текстового поля
        private void ean13Text_TextChanged(object sender, EventArgs e)
        {
            ok.Enabled = false;
            if (ean13Text.Text.Length!=0&& ean13Text.Text.Length==13)
            {
                    
                    string barcode = ean13Text.Text;
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    g.Clear(Color.White);
                    SolidBrush myBrash = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    float space = 15;
                    float x1 = 5, y1 = 5;
                    float x2 = 5, y2 = 150;
                    for (int i = 0; i < barcode.Length; i++)
                    {
                        Pen mypen = new Pen(Color.Black, bars[int.Parse(barcode[i].ToString())]);
                        g.DrawLine(mypen, x1, y1, x2, y2);
                        Font font = new Font("Arial", 8);
                        g.DrawString(barcode[i].ToString(), font, myBrash, x2, y2 + 10);
                        x1 += space;
                        x2 += space;
                    }
                    pictureBox1.Invalidate();
            }
        }

        //получение данных
        private void setdates_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;
            string ser = setdates.SelectedItem.ToString();
            using (PoliclinicDB db = new PoliclinicDB())
            {
                var test = from a in db.Service
                           join b in db.SetService on a.SetServiceId equals b.Id
                           where b.Name.Equals(ser)
                           select new
                           {
                               ServiceName = a.Name,
                               CostService = a.Cost
                           };
                int i = 0;
                foreach (var t in test)
                {
                    checkedListBox1.Items.Add(t.ServiceName);
                }
            }
        }

        //сохранение в бд (доделать надо)
        private void addOrdersOkay_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            using (PoliclinicDB db = new PoliclinicDB())
            {
                if(checkedListBox1.CheckedItems.Count==1)
                {
                    if (ean13Text.Text.Length != 0 && namesPacients.Text.Length != 0 && barcode.Text.Length != 0 && setdates.Items.Count != 0 && checkedListBox1.Items.Count != 0)
                    {
                        string services = checkedListBox1.Text;
                        list.Add(services);
                        string comText = barcode.Text;
                        string[] mas = comText.Split(' ');
                        string firstCode = mas[1];
                        string secondName = mas[2];
                        Order order = new Order();
                        var pacie = db.Pacients.Where(p => p.FIO.Equals(namesPacients.Text)).FirstOrDefault();
                        var setS = db.SetService.Where(t => t.Name.Equals(setdates.Text)).FirstOrDefault();
                        var serv = db.Service.Where(s => s.Name.Equals(services)).FirstOrDefault();
                        //var bio = db.Biomaterial.Where(k => k.CodeBiomaterial.Equals(barcode.Text)).FirstOrDefault();
                        var user = db.Users.Where(l => l.Login.Equals(emails)).FirstOrDefault();
                        order.IdPacient = pacie.ID;
                        order.IdSetService = setS.Id;
                        order.Bacode = double.Parse(ean13Text.Text);
                        order.IdService = serv.ID;
                        order.Status = "OK";
                        //order.BiomaterialId = bio.IdBiomaterial;
                        order.DataOrder = DateTime.Now;
                        Rendering rendering = new Rendering();
                        rendering.IdService = setS.Id;
                        rendering.UserId = user.ID;
                        rendering.Period = DateTime.Now.ToString();
                        rendering.Analyzer = "Ledect";
                        db.Order.Add(order);
                        db.Rendering.Add(rendering);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                }
                else if(checkedListBox1.CheckedItems.Count!=1)
                {
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        if (ean13Text.Text.Length!=0 && namesPacients.Text.Length != 0 && barcode.Text.Length != 0 && setdates.Items.Count != 0 && checkedListBox1.Items.Count != 0)
                        {
                            string services = item.ToString();
                            list.Add(services);
                            Order order = new Order();
                            var pacie = db.Pacients.Where(p => p.FIO.Equals(namesPacients.Text)).FirstOrDefault();
                            var setS = db.SetService.Where(t => t.Name.Equals(setdates.Text)).FirstOrDefault();
                            var serv = db.Service.Where(s => s.Name.Equals(services)).FirstOrDefault();
                            order.IdPacient = pacie.ID;
                            order.IdSetService = setS.Id;
                            order.Bacode = double.Parse(ean13Text.Text);
                            order.IdService = serv.ID;
                            order.Status = "OK";
                            db.Order.Add(order);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля");
                        }
                    }
                }
                
                list.Distinct();
                MessageBox.Show("Вы успешно добавили новый заказ");
                PrintingForm printing = new PrintingForm(ean13Text.Text, list);
                printing.Show();
            }
        }

        //только цифры, буквы нельзя
        private void ean13Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>='0' &&e.KeyChar<='9')
            {
                return;
            }
            e.Handled = true;
        }

        //левенштейн
        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;

        private static int LevenshteinDistance(string item, string nam)
        {
            var n = item.Length;
            var m = nam.Length;
            var matrix = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = i;
            }
            for (int j = 0; j < m; j++)
            {
                matrix[0, j] = j;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    var substitutionCost = item[i - 1] == nam[j - 1] ? 0 : 1;

                    matrix[i, j] = Minimum(matrix[i - 1, j] + deletionCost,          // удаление
                                            matrix[i, j - 1] + insertionCost,         // вставка
                                            matrix[i - 1, j - 1] + substitutionCost); // замена
                }
            }

            return matrix[n - 1, m - 1];
        }

        //работа с расстоянием(не рабочее)
        private void namesPacients_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                //string first = namesPacients.Text;
                //AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                //using (PoliclinicDB db = new PoliclinicDB())
                //{
                //    var test = from a in db.Pacients
                //               select a;
                //    foreach (var t in test)
                //    {
                //        if(LevenshteinDistance(first,t.FIO)!=0)
                //        {
                //            source.Add(t.FIO);
                //        }
                //    }
                //}
                //namesPacients.AutoCompleteCustomSource = source;
                //namesPacients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //namesPacients.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //изменение пациента
        private void edit_Click(object sender, EventArgs e)
        {
            if(namesPacients.Text.Length!=0)
            {
                //EditPacientsForm editPacients = new EditPacientsForm(namesPacients.Text);
                //editPacients.Show();
                EditPacientsForm editPacientsForm = EditPacientsForm.getInstance(namesPacients.Text);
                editPacientsForm.Show();
            }
            else
            {
                MessageBox.Show("Введите имя пациента");
            }
        }

        private void GetBioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NullInstance();
        }
    }
}
