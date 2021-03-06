namespace WS20
{
    partial class ChangeReportForm
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
            this.reportTable = new System.Windows.Forms.Button();
            this.chartReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportTable
            // 
            this.reportTable.Location = new System.Drawing.Point(39, 28);
            this.reportTable.Name = "reportTable";
            this.reportTable.Size = new System.Drawing.Size(404, 50);
            this.reportTable.TabIndex = 1;
            this.reportTable.Text = "Формирование отчета (таблица)";
            this.reportTable.UseVisualStyleBackColor = true;
            this.reportTable.Click += new System.EventHandler(this.reportTable_Click);
            // 
            // chartReport
            // 
            this.chartReport.Location = new System.Drawing.Point(39, 99);
            this.chartReport.Name = "chartReport";
            this.chartReport.Size = new System.Drawing.Size(404, 50);
            this.chartReport.TabIndex = 2;
            this.chartReport.Text = "Формирование отчета (график)";
            this.chartReport.UseVisualStyleBackColor = true;
            this.chartReport.Click += new System.EventHandler(this.chartReport_Click);
            // 
            // ChangeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 171);
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.reportTable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeReportForm";
            this.Text = "Выбор отчетов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeReportForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button reportTable;
        private System.Windows.Forms.Button chartReport;
    }
}