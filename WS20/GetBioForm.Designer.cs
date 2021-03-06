namespace WS20
{
    partial class GetBioForm
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
            this.ean13Text = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.print = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.setdates = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addOrdersOkay = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.namesPacients = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите штрих-код";
            // 
            // ean13Text
            // 
            this.ean13Text.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ean13Text.Location = new System.Drawing.Point(12, 45);
            this.ean13Text.MaxLength = 13;
            this.ean13Text.Name = "ean13Text";
            this.ean13Text.Size = new System.Drawing.Size(245, 29);
            this.ean13Text.TabIndex = 1;
            this.ean13Text.TextChanged += new System.EventHandler(this.ean13Text_TextChanged);
            this.ean13Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ean13Text_KeyPress);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ok.Location = new System.Drawing.Point(263, 42);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(158, 35);
            this.ok.TabIndex = 2;
            this.ok.Text = "Сгенерировать";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Arial", 14.25F);
            this.print.Location = new System.Drawing.Point(12, 339);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(181, 35);
            this.print.TabIndex = 2;
            this.print.Text = "На печать";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click_1);
            // 
            // setdates
            // 
            this.setdates.FormattingEnabled = true;
            this.setdates.Location = new System.Drawing.Point(451, 215);
            this.setdates.Name = "setdates";
            this.setdates.Size = new System.Drawing.Size(246, 21);
            this.setdates.TabIndex = 18;
            this.setdates.SelectedIndexChanged += new System.EventHandler(this.setdates_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(246, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addOrdersOkay
            // 
            this.addOrdersOkay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrdersOkay.Location = new System.Drawing.Point(50, 380);
            this.addOrdersOkay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addOrdersOkay.Name = "addOrdersOkay";
            this.addOrdersOkay.Size = new System.Drawing.Size(121, 31);
            this.addOrdersOkay.TabIndex = 15;
            this.addOrdersOkay.Text = "ОK";
            this.addOrdersOkay.UseVisualStyleBackColor = true;
            this.addOrdersOkay.Click += new System.EventHandler(this.addOrdersOkay_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(201, 339);
            this.add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(166, 35);
            this.add.TabIndex = 16;
            this.add.Text = "Добавить пациента";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(447, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(447, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "ФИО пациента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(447, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Перечень услуг";
            // 
            // barcode
            // 
            this.barcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcode.Location = new System.Drawing.Point(451, 80);
            this.barcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barcode.MaxLength = 16;
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(246, 29);
            this.barcode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(447, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Код биоматериала";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(451, 272);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(358, 139);
            this.checkedListBox1.TabIndex = 20;
            // 
            // namesPacients
            // 
            this.namesPacients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesPacients.Location = new System.Drawing.Point(451, 142);
            this.namesPacients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.namesPacients.Name = "namesPacients";
            this.namesPacients.Size = new System.Drawing.Size(246, 29);
            this.namesPacients.TabIndex = 13;
            this.namesPacients.TextChanged += new System.EventHandler(this.namesPacients_TextChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(702, 142);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(131, 29);
            this.edit.TabIndex = 21;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // GetBioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 429);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.setdates);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addOrdersOkay);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namesPacients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.ean13Text);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetBioForm";
            this.Text = "Прием биоматериала";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetBioForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ean13Text;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox setdates;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addOrdersOkay;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox namesPacients;
        private System.Windows.Forms.Button edit;
    }
}