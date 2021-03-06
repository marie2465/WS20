namespace WS20
{
    partial class AnalyzeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.biomaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.analyze = new System.Windows.Forms.ComboBox();
            this.okay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.typeResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отправка на анализатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // nameService
            // 
            this.nameService.BackColor = System.Drawing.Color.White;
            this.nameService.Location = new System.Drawing.Point(163, 77);
            this.nameService.Name = "nameService";
            this.nameService.ReadOnly = true;
            this.nameService.Size = new System.Drawing.Size(343, 29);
            this.nameService.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Стоимость";
            // 
            // cost
            // 
            this.cost.BackColor = System.Drawing.Color.White;
            this.cost.Location = new System.Drawing.Point(163, 126);
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Size = new System.Drawing.Size(343, 29);
            this.cost.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Биоматериал";
            // 
            // biomaterial
            // 
            this.biomaterial.BackColor = System.Drawing.Color.White;
            this.biomaterial.Location = new System.Drawing.Point(163, 175);
            this.biomaterial.Multiline = true;
            this.biomaterial.Name = "biomaterial";
            this.biomaterial.ReadOnly = true;
            this.biomaterial.Size = new System.Drawing.Size(343, 79);
            this.biomaterial.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Анализатор";
            // 
            // analyze
            // 
            this.analyze.FormattingEnabled = true;
            this.analyze.Items.AddRange(new object[] {
            "Ledect",
            "Biorad",
            "Ledect | Biorad"});
            this.analyze.Location = new System.Drawing.Point(163, 328);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(343, 29);
            this.analyze.TabIndex = 3;
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(115, 372);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(273, 47);
            this.okay.TabIndex = 4;
            this.okay.Text = "OK";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Тип результата";
            // 
            // typeResult
            // 
            this.typeResult.FormattingEnabled = true;
            this.typeResult.Items.AddRange(new object[] {
            "String",
            "Integer"});
            this.typeResult.Location = new System.Drawing.Point(163, 269);
            this.typeResult.Name = "typeResult";
            this.typeResult.Size = new System.Drawing.Size(343, 29);
            this.typeResult.TabIndex = 3;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 519);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.typeResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.analyze);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.biomaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnalyzeForm";
            this.Text = "Анализатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox biomaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox analyze;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeResult;
    }
}