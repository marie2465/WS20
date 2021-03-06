namespace WS20
{
    partial class EditPacientsForm
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
            this.typePolicy = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.ComboBox();
            this.cancle = new System.Windows.Forms.Button();
            this.okay = new System.Windows.Forms.Button();
            this.telephone = new System.Windows.Forms.MaskedTextBox();
            this.numberPassport = new System.Windows.Forms.MaskedTextBox();
            this.seriaPassport = new System.Windows.Forms.MaskedTextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numberPolicy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namePacient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typePolicy
            // 
            this.typePolicy.FormattingEnabled = true;
            this.typePolicy.Items.AddRange(new object[] {
            "Обязательный полис мед. страхования",
            "Временный полис мед. страхования"});
            this.typePolicy.Location = new System.Drawing.Point(289, 139);
            this.typePolicy.Name = "typePolicy";
            this.typePolicy.Size = new System.Drawing.Size(215, 29);
            this.typePolicy.TabIndex = 38;
            // 
            // company
            // 
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(289, 202);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(215, 29);
            this.company.TabIndex = 35;
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(395, 363);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(109, 29);
            this.cancle.TabIndex = 37;
            this.cancle.Text = "Cancel";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(289, 363);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(100, 29);
            this.okay.TabIndex = 36;
            this.okay.Text = "OK";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(25, 258);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(215, 29);
            this.telephone.TabIndex = 30;
            // 
            // numberPassport
            // 
            this.numberPassport.Location = new System.Drawing.Point(108, 202);
            this.numberPassport.Mask = "000000";
            this.numberPassport.Name = "numberPassport";
            this.numberPassport.Size = new System.Drawing.Size(132, 29);
            this.numberPassport.TabIndex = 29;
            // 
            // seriaPassport
            // 
            this.seriaPassport.Location = new System.Drawing.Point(25, 202);
            this.seriaPassport.Mask = "0000 ";
            this.seriaPassport.Name = "seriaPassport";
            this.seriaPassport.Size = new System.Drawing.Size(77, 29);
            this.seriaPassport.TabIndex = 28;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(25, 139);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(215, 29);
            this.dateOfBirth.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Страховая компания";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Тип страхового полиса";
            // 
            // numberPolicy
            // 
            this.numberPolicy.Location = new System.Drawing.Point(289, 75);
            this.numberPolicy.Name = "numberPolicy";
            this.numberPolicy.Size = new System.Drawing.Size(215, 29);
            this.numberPolicy.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер страхового полиса";
            // 
            // e_mail
            // 
            this.e_mail.Location = new System.Drawing.Point(25, 323);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(215, 29);
            this.e_mail.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "e-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Серия и номер паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Дата рождения";
            // 
            // namePacient
            // 
            this.namePacient.Location = new System.Drawing.Point(25, 75);
            this.namePacient.Name = "namePacient";
            this.namePacient.Size = new System.Drawing.Size(215, 29);
            this.namePacient.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ф.И.О.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Редактирование пациента";
            // 
            // EditPacientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 422);
            this.Controls.Add(this.typePolicy);
            this.Controls.Add(this.company);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.numberPassport);
            this.Controls.Add(this.seriaPassport);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numberPolicy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.e_mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namePacient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditPacientsForm";
            this.Text = "Редактирование пациента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditPacientsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typePolicy;
        private System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.MaskedTextBox telephone;
        private System.Windows.Forms.MaskedTextBox numberPassport;
        private System.Windows.Forms.MaskedTextBox seriaPassport;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numberPolicy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namePacient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}