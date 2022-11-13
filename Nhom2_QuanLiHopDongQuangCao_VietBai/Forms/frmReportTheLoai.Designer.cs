namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Forms
{
    partial class frmReportTheLoai
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpvTheLoai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenBao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Nhom2_QuanLiHopDongQuangCao_VietBai.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(762, 34);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 31);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = global::Nhom2_QuanLiHopDongQuangCao_VietBai.Properties.Resources.Report;
            this.btnBaoCao.Location = new System.Drawing.Point(538, 36);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(126, 31);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Report";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên báo";
            // 
            // txtTenBao
            // 
            this.txtTenBao.Location = new System.Drawing.Point(126, 36);
            this.txtTenBao.Name = "txtTenBao";
            this.txtTenBao.Size = new System.Drawing.Size(288, 26);
            this.txtTenBao.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rpvTheLoai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 419);
            this.panel2.TabIndex = 1;
            // 
            // rpvTheLoai
            // 
            this.rpvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.rpvTheLoai.Name = "rpvTheLoai";
            this.rpvTheLoai.ServerReport.BearerToken = null;
            this.rpvTheLoai.Size = new System.Drawing.Size(1101, 419);
            this.rpvTheLoai.TabIndex = 0;
            this.rpvTheLoai.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmReportTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportTheLoai";
            this.Text = "frmReportTheLoai";
            this.Load += new System.EventHandler(this.frmReportTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvTheLoai;
    }
}