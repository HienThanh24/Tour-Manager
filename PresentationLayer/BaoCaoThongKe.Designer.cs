namespace PresentationLayer
{
    partial class BaoCaoThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboReportType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblReportType;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cboReportType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblReportType = new System.Windows.Forms.Label();
            this.ChartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // cboReportType
            // 
            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.Location = new System.Drawing.Point(150, 18);
            this.cboReportType.Items.AddRange(new object[] {
            "Doanh thu theo ngày",
            "Doanh thu theo loại Tour"});
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(250, 24);
            this.cboReportType.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(420, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(126, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Từ ngày - Đến ngày:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(550, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(786, 18);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(1068, 14);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(100, 30);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Tạo báo cáo";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeight = 29;
            this.dgvReport.Location = new System.Drawing.Point(34, 91);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(1500, 228);
            this.dgvReport.TabIndex = 6;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(20, 20);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(119, 16);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Chọn loại báo cáo:";
            // 
            // ChartMain
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartMain.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChartMain.Legends.Add(legend4);
            this.ChartMain.Location = new System.Drawing.Point(34, 344);
            this.ChartMain.Name = "ChartMain";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChartMain.Series.Add(series4);
            this.ChartMain.Size = new System.Drawing.Size(1499, 313);
            this.ChartMain.TabIndex = 7;
            this.ChartMain.Text = "chart1";
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 698);
            this.Controls.Add(this.ChartMain);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cboReportType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvReport);
            this.Name = "BaoCaoThongKe";
            this.Text = "Báo Cáo Thống Kê Doanh Thu";
            this.Load += new System.EventHandler(this.BaoCaoThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMain;
    }
}
