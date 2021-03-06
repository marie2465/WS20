namespace WS20
{
    partial class PrintinigScoreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CostService = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.periodCost = new System.Windows.Forms.Label();
            this.insureCompany = new System.Windows.Forms.Label();
            this.okay = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.namesPacients = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.namesPacients);
            this.panel1.Controls.Add(this.insureCompany);
            this.panel1.Controls.Add(this.periodCost);
            this.panel1.Controls.Add(this.CostService);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 702);
            this.panel1.TabIndex = 0;
            // 
            // CostService
            // 
            this.CostService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CostService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostService.FormattingEnabled = true;
            this.CostService.ItemHeight = 21;
            this.CostService.Location = new System.Drawing.Point(164, 523);
            this.CostService.Name = "CostService";
            this.CostService.Size = new System.Drawing.Size(597, 168);
            this.CostService.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Стоимость услуг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "ФИО пациентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Период оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Наименование";
            // 
            // periodCost
            // 
            this.periodCost.AutoSize = true;
            this.periodCost.BackColor = System.Drawing.Color.White;
            this.periodCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodCost.Location = new System.Drawing.Point(167, 66);
            this.periodCost.MinimumSize = new System.Drawing.Size(594, 0);
            this.periodCost.Name = "periodCost";
            this.periodCost.Size = new System.Drawing.Size(594, 21);
            this.periodCost.TabIndex = 27;
            // 
            // insureCompany
            // 
            this.insureCompany.AutoSize = true;
            this.insureCompany.BackColor = System.Drawing.Color.White;
            this.insureCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insureCompany.Location = new System.Drawing.Point(167, 17);
            this.insureCompany.MinimumSize = new System.Drawing.Size(594, 0);
            this.insureCompany.Name = "insureCompany";
            this.insureCompany.Size = new System.Drawing.Size(594, 21);
            this.insureCompany.TabIndex = 27;
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(171, 708);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(162, 37);
            this.okay.TabIndex = 1;
            this.okay.Text = "Ок";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(407, 708);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(162, 37);
            this.Cancle.TabIndex = 1;
            this.Cancle.Text = "Отмена";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // namesPacients
            // 
            this.namesPacients.BackColor = System.Drawing.Color.White;
            this.namesPacients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namesPacients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesPacients.Location = new System.Drawing.Point(164, 100);
            this.namesPacients.Multiline = true;
            this.namesPacients.Name = "namesPacients";
            this.namesPacients.ReadOnly = true;
            this.namesPacients.Size = new System.Drawing.Size(601, 404);
            this.namesPacients.TabIndex = 28;
            this.namesPacients.TextChanged += new System.EventHandler(this.namesPacients_TextChanged);
            // 
            // PrintinigScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 757);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintinigScoreForm";
            this.Text = "Предварительный просмотр счета";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label insureCompany;
        private System.Windows.Forms.Label periodCost;
        private System.Windows.Forms.ListBox CostService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Button Cancle;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox namesPacients;
    }
}