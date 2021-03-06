namespace WS20
{
    partial class ReportchartSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cancle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.repTable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.averageResult = new System.Windows.Forms.TextBox();
            this.pacien = new System.Windows.Forms.TextBox();
            this.averagePac = new System.Windows.Forms.TextBox();
            this.setService = new System.Windows.Forms.TextBox();
            this.servicesCount = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(870, 607);
            this.cancle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(126, 39);
            this.cancle.TabIndex = 26;
            this.cancle.Text = "Отмена";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 607);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // repTable
            // 
            this.repTable.Location = new System.Drawing.Point(18, 193);
            this.repTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repTable.Name = "repTable";
            this.repTable.Size = new System.Drawing.Size(170, 31);
            this.repTable.TabIndex = 24;
            this.repTable.Text = "Сформировать";
            this.repTable.UseVisualStyleBackColor = true;
            this.repTable.Click += new System.EventHandler(this.repTable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "По ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "C ";
            // 
            // averageResult
            // 
            this.averageResult.Location = new System.Drawing.Point(635, 200);
            this.averageResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.averageResult.Name = "averageResult";
            this.averageResult.Size = new System.Drawing.Size(325, 29);
            this.averageResult.TabIndex = 21;
            // 
            // pacien
            // 
            this.pacien.Location = new System.Drawing.Point(635, 117);
            this.pacien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pacien.Name = "pacien";
            this.pacien.Size = new System.Drawing.Size(325, 29);
            this.pacien.TabIndex = 20;
            // 
            // averagePac
            // 
            this.averagePac.Location = new System.Drawing.Point(635, 160);
            this.averagePac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.averagePac.Name = "averagePac";
            this.averagePac.Size = new System.Drawing.Size(325, 29);
            this.averagePac.TabIndex = 17;
            // 
            // setService
            // 
            this.setService.Location = new System.Drawing.Point(635, 76);
            this.setService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setService.Name = "setService";
            this.setService.Size = new System.Drawing.Size(325, 29);
            this.setService.TabIndex = 15;
            // 
            // servicesCount
            // 
            this.servicesCount.Location = new System.Drawing.Point(635, 33);
            this.servicesCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.servicesCount.Name = "servicesCount";
            this.servicesCount.Size = new System.Drawing.Size(325, 29);
            this.servicesCount.TabIndex = 14;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(52, 76);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(188, 29);
            this.endDate.TabIndex = 18;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(52, 40);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(188, 29);
            this.startDate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Период:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Количество пациентов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Средний результат каждого исследования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Среднее количество пациентов в день";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Перечень  услуг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количество оказаных услуг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Отчет по указанным услугам";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 237);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Пациенты";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Услуги";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Перечень услуг";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(964, 326);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.repTable);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.averageResult);
            this.panel1.Controls.Add(this.pacien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.averagePac);
            this.panel1.Controls.Add(this.setService);
            this.panel1.Controls.Add(this.servicesCount);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 566);
            this.panel1.TabIndex = 28;
            // 
            // ReportchartSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportchartSForm";
            this.Text = "ReportchartSForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportchartSForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportchartSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button repTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox averageResult;
        private System.Windows.Forms.TextBox pacien;
        private System.Windows.Forms.TextBox averagePac;
        private System.Windows.Forms.TextBox setService;
        private System.Windows.Forms.TextBox servicesCount;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
    }
}