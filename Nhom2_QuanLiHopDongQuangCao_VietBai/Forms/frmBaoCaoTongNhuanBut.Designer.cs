namespace Nhom2_QuanLiHopDongQuangCao_VietBai.Forms
{
    partial class frmBaoCaoTongNhuanBut
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
            this.btnNam = new System.Windows.Forms.Button();
            this.btnQuy = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.dgvBCTNB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCTNB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnNam);
            this.panel1.Controls.Add(this.btnQuy);
            this.panel1.Controls.Add(this.btnThang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 91);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Image = global::Nhom2_QuanLiHopDongQuangCao_VietBai.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(737, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(175, 40);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.SystemColors.Control;
            this.btnNam.Location = new System.Drawing.Point(507, 30);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(175, 40);
            this.btnNam.TabIndex = 2;
            this.btnNam.Text = "Nhuận bút theo năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnQuy
            // 
            this.btnQuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuy.Location = new System.Drawing.Point(277, 30);
            this.btnQuy.Name = "btnQuy";
            this.btnQuy.Size = new System.Drawing.Size(175, 40);
            this.btnQuy.TabIndex = 1;
            this.btnQuy.Text = "Nhuận bút theo quý";
            this.btnQuy.UseVisualStyleBackColor = false;
            this.btnQuy.Click += new System.EventHandler(this.btnQuy_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.SystemColors.Control;
            this.btnThang.Location = new System.Drawing.Point(47, 30);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(175, 40);
            this.btnThang.TabIndex = 0;
            this.btnThang.Text = "Nhuận bút theo tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // dgvBCTNB
            // 
            this.dgvBCTNB.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvBCTNB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCTNB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBCTNB.Location = new System.Drawing.Point(0, 0);
            this.dgvBCTNB.Name = "dgvBCTNB";
            this.dgvBCTNB.RowHeadersWidth = 62;
            this.dgvBCTNB.RowTemplate.Height = 28;
            this.dgvBCTNB.Size = new System.Drawing.Size(1101, 428);
            this.dgvBCTNB.TabIndex = 4;
            // 
            // frmBaoCaoTongNhuanBut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 519);
            this.Controls.Add(this.dgvBCTNB);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoTongNhuanBut";
            this.Text = "frmBaoCaoTongNhuanBut";
            this.Load += new System.EventHandler(this.frmBaoCaoTongNhuanBut_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCTNB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnQuy;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.DataGridView dgvBCTNB;
    }
}