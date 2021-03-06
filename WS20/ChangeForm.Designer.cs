namespace WS20
{
    partial class ChangeForm
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
            this.pdf_file = new System.Windows.Forms.Button();
            this.csv_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdf_file
            // 
            this.pdf_file.Location = new System.Drawing.Point(24, 27);
            this.pdf_file.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pdf_file.Name = "pdf_file";
            this.pdf_file.Size = new System.Drawing.Size(512, 76);
            this.pdf_file.TabIndex = 1;
            this.pdf_file.Text = "Выгрузить pdf-файл";
            this.pdf_file.UseVisualStyleBackColor = true;
            this.pdf_file.Click += new System.EventHandler(this.pdf_file_Click);
            // 
            // csv_file
            // 
            this.csv_file.Location = new System.Drawing.Point(24, 149);
            this.csv_file.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.csv_file.Name = "csv_file";
            this.csv_file.Size = new System.Drawing.Size(512, 76);
            this.csv_file.TabIndex = 2;
            this.csv_file.Text = "Выгрузить csv-файл";
            this.csv_file.UseVisualStyleBackColor = true;
            this.csv_file.Click += new System.EventHandler(this.csv_file_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 261);
            this.Controls.Add(this.csv_file);
            this.Controls.Add(this.pdf_file);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pdf_file;
        private System.Windows.Forms.Button csv_file;
    }
}