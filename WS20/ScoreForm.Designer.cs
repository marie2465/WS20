namespace WS20
{
    partial class ScoreForm
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
            this.company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameInsure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.periodCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CostService = new System.Windows.Forms.ListBox();
            this.okay = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.DateTimePicker();
            this.namesPacients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // company
            // 
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(13, 46);
            this.company.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(218, 29);
            this.company.TabIndex = 0;
            this.company.TextChanged += new System.EventHandler(this.company_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Страховая компания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Период:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование";
            // 
            // nameInsure
            // 
            this.nameInsure.Location = new System.Drawing.Point(470, 30);
            this.nameInsure.Name = "nameInsure";
            this.nameInsure.Size = new System.Drawing.Size(390, 29);
            this.nameInsure.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Период оплаты";
            // 
            // periodCost
            // 
            this.periodCost.Location = new System.Drawing.Point(470, 81);
            this.periodCost.Name = "periodCost";
            this.periodCost.Size = new System.Drawing.Size(390, 29);
            this.periodCost.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "ФИО пациентов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Стоимость услуг";
            // 
            // CostService
            // 
            this.CostService.FormattingEnabled = true;
            this.CostService.ItemHeight = 21;
            this.CostService.Location = new System.Drawing.Point(470, 395);
            this.CostService.Name = "CostService";
            this.CostService.Size = new System.Drawing.Size(390, 214);
            this.CostService.TabIndex = 7;
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(11, 174);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(124, 32);
            this.okay.TabIndex = 8;
            this.okay.Text = "Ок";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(150, 174);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(124, 32);
            this.Cancle.TabIndex = 8;
            this.Cancle.Text = "Отмена";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(13, 125);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(218, 29);
            this.period.TabIndex = 9;
            // 
            // namesPacients
            // 
            this.namesPacients.FormattingEnabled = true;
            this.namesPacients.HorizontalScrollbar = true;
            this.namesPacients.ItemHeight = 21;
            this.namesPacients.Location = new System.Drawing.Point(319, 156);
            this.namesPacients.Name = "namesPacients";
            this.namesPacients.Size = new System.Drawing.Size(877, 214);
            this.namesPacients.TabIndex = 10;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 604);
            this.Controls.Add(this.namesPacients);
            this.Controls.Add(this.period);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.CostService);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.periodCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameInsure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.company);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Счет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameInsure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox periodCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox CostService;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.DateTimePicker period;
        private System.Windows.Forms.ListBox namesPacients;
    }
}