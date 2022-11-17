namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Forms
{
    partial class frmReportSoLanNGB_NQC
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
            this.rpvSoLanNGB_NQC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvSoLanNGB_NQC
            // 
            this.rpvSoLanNGB_NQC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSoLanNGB_NQC.Location = new System.Drawing.Point(0, 0);
            this.rpvSoLanNGB_NQC.Name = "rpvSoLanNGB_NQC";
            this.rpvSoLanNGB_NQC.ServerReport.BearerToken = null;
            this.rpvSoLanNGB_NQC.Size = new System.Drawing.Size(1101, 519);
            this.rpvSoLanNGB_NQC.TabIndex = 0;
            this.rpvSoLanNGB_NQC.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmReportSoLanNGB_NQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 519);
            this.Controls.Add(this.rpvSoLanNGB_NQC);
            this.Name = "frmReportSoLanNGB_NQC";
            this.Text = "Báo cáo số lần gửi bài và nhận quảng cáo của các nhân viên";
            this.Load += new System.EventHandler(this.frmReportSoLanNGB_NQC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSoLanNGB_NQC;
    }
}