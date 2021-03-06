namespace WS20
{
    partial class CsvScoreForm
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
            this.namesPacients = new System.Windows.Forms.TextBox();
            this.insureCompany = new System.Windows.Forms.Label();
            this.periodCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancle = new System.Windows.Forms.Button();
            this.okay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CostService = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namesPacients
            // 
            this.namesPacients.BackColor = System.Drawing.Color.White;
            this.namesPacients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namesPacients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesPacients.Location = new System.Drawing.Point(168, 82);
            this.namesPacients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namesPacients.Multiline = true;
            this.namesPacients.Name = "namesPacients";
            this.namesPacients.ReadOnly = true;
            this.namesPacients.Size = new System.Drawing.Size(590, 366);
            this.namesPacients.TabIndex = 36;
            // 
            // insureCompany
            // 
            this.insureCompany.AutoSize = true;
            this.insureCompany.BackColor = System.Drawing.Color.White;
            this.insureCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insureCompany.Location = new System.Drawing.Point(164, 9);
            this.insureCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.insureCompany.MinimumSize = new System.Drawing.Size(594, 0);
            this.insureCompany.Name = "insureCompany";
            this.insureCompany.Size = new System.Drawing.Size(594, 21);
            this.insureCompany.TabIndex = 34;
            // 
            // periodCost
            // 
            this.periodCost.AutoSize = true;
            this.periodCost.BackColor = System.Drawing.Color.White;
            this.periodCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodCost.Location = new System.Drawing.Point(164, 45);
            this.periodCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.periodCost.MinimumSize = new System.Drawing.Size(594, 0);
            this.periodCost.Name = "periodCost";
            this.periodCost.Size = new System.Drawing.Size(594, 21);
            this.periodCost.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 471);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Стоимость услуг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "ФИО пациентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Период оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Наименование";
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(608, 1158);
            this.Cancle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(243, 60);
            this.Cancle.TabIndex = 37;
            this.Cancle.Text = "Отмена";
            this.Cancle.UseVisualStyleBackColor = true;
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(254, 1158);
            this.okay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(243, 60);
            this.okay.TabIndex = 38;
            this.okay.Text = "Ок";
            this.okay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 742);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 33);
            this.button1.TabIndex = 39;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 742);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 33);
            this.button2.TabIndex = 39;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CostService
            // 
            this.CostService.Location = new System.Drawing.Point(168, 471);
            this.CostService.Multiline = true;
            this.CostService.Name = "CostService";
            this.CostService.Size = new System.Drawing.Size(590, 225);
            this.CostService.TabIndex = 40;
            // 
            // CsvScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(789, 797);
            this.Controls.Add(this.CostService);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.namesPacients);
            this.Controls.Add(this.insureCompany);
            this.Controls.Add(this.periodCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CsvScoreForm";
            this.Text = "Выгрузка в csv-файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namesPacients;
        private System.Windows.Forms.Label insureCompany;
        private System.Windows.Forms.Label periodCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CostService;
    }
}