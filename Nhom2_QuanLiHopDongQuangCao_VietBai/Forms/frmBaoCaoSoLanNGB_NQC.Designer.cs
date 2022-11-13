namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Forms
{
    partial class frmBaoCaoSoLanNGB_NQC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvBaoCaoSoLanNGB_NQC = new System.Windows.Forms.DataGridView();
            this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSoLanNGB_NQC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.dgvBaoCaoSoLanNGB_NQC);
            this.panel1.Controls.Add(this.chartCot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 519);
            this.panel1.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::Nhom2_QuanLiHopDongQuangCao_VietBai.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(835, 191);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 38);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvBaoCaoSoLanNGB_NQC
            // 
            this.dgvBaoCaoSoLanNGB_NQC.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvBaoCaoSoLanNGB_NQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoSoLanNGB_NQC.Location = new System.Drawing.Point(98, 0);
            this.dgvBaoCaoSoLanNGB_NQC.Name = "dgvBaoCaoSoLanNGB_NQC";
            this.dgvBaoCaoSoLanNGB_NQC.RowHeadersWidth = 62;
            this.dgvBaoCaoSoLanNGB_NQC.RowTemplate.Height = 28;
            this.dgvBaoCaoSoLanNGB_NQC.Size = new System.Drawing.Size(713, 248);
            this.dgvBaoCaoSoLanNGB_NQC.TabIndex = 6;
            // 
            // chartCot
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCot.ChartAreas.Add(chartArea2);
            this.chartCot.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chartCot.Legends.Add(legend2);
            this.chartCot.Location = new System.Drawing.Point(0, 248);
            this.chartCot.Name = "chartCot";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "SoLanGui";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "SoLanQC";
            this.chartCot.Series.Add(series3);
            this.chartCot.Series.Add(series4);
            this.chartCot.Size = new System.Drawing.Size(1101, 271);
            this.chartCot.TabIndex = 1;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = global::Nhom2_QuanLiHopDongQuangCao_VietBai.Properties.Resources.Report;
            this.btnBaoCao.Location = new System.Drawing.Point(835, 116);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(98, 38);
            this.btnBaoCao.TabIndex = 11;
            this.btnBaoCao.Text = "Report";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // frmBaoCaoSoLanNGB_NQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 519);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoSoLanNGB_NQC";
            this.Text = "frmBaoCaoSoLanNGB_NQC";
            this.Load += new System.EventHandler(this.frmBaoCaoSoLanNGB_NQC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSoLanNGB_NQC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
        private System.Windows.Forms.DataGridView dgvBaoCaoSoLanNGB_NQC;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
    }
}