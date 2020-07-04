namespace QL_ChanNuoi.Design
{
    partial class form_BenhVatNuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_BenhVatNuoi));
            this.txt_NguyenNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenBenh = new System.Windows.Forms.TextBox();
            this.txt_MaBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txt_TrieuChung = new System.Windows.Forms.TextBox();
            this.GV_BenhVatNuoi = new System.Windows.Forms.DataGridView();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChungBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenNhanBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDieuTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CachDieuTri = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BenhVatNuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NguyenNhan
            // 
            this.txt_NguyenNhan.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NguyenNhan.Location = new System.Drawing.Point(200, 336);
            this.txt_NguyenNhan.Name = "txt_NguyenNhan";
            this.txt_NguyenNhan.Size = new System.Drawing.Size(891, 39);
            this.txt_NguyenNhan.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nguyên Nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Triệu Chứng:";
            // 
            // txt_TenBenh
            // 
            this.txt_TenBenh.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenBenh.Location = new System.Drawing.Point(200, 161);
            this.txt_TenBenh.Name = "txt_TenBenh";
            this.txt_TenBenh.Size = new System.Drawing.Size(364, 39);
            this.txt_TenBenh.TabIndex = 32;
            // 
            // txt_MaBenh
            // 
            this.txt_MaBenh.Enabled = false;
            this.txt_MaBenh.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaBenh.Location = new System.Drawing.Point(200, 93);
            this.txt_MaBenh.Name = "txt_MaBenh";
            this.txt_MaBenh.Size = new System.Drawing.Size(301, 39);
            this.txt_MaBenh.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Bệnh:";
            // 
            // toolStripButton_Luu
            // 
            this.toolStripButton_Luu.Enabled = false;
            this.toolStripButton_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Luu.Image")));
            this.toolStripButton_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Luu.Name = "toolStripButton_Luu";
            this.toolStripButton_Luu.Size = new System.Drawing.Size(90, 36);
            this.toolStripButton_Luu.Text = "Lưu";
            this.toolStripButton_Luu.Click += new System.EventHandler(this.toolStripButton_Luu_Click);
            // 
            // toolStripButton_Xoa
            // 
            this.toolStripButton_Xoa.Enabled = false;
            this.toolStripButton_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Xoa.Image")));
            this.toolStripButton_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Xoa.Name = "toolStripButton_Xoa";
            this.toolStripButton_Xoa.Size = new System.Drawing.Size(91, 36);
            this.toolStripButton_Xoa.Text = "Xóa";
            this.toolStripButton_Xoa.Click += new System.EventHandler(this.toolStripButton_Xoa_Click);
            // 
            // toolStripButton_Them
            // 
            this.toolStripButton_Them.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Them.Image")));
            this.toolStripButton_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Them.Name = "toolStripButton_Them";
            this.toolStripButton_Them.Size = new System.Drawing.Size(112, 36);
            this.toolStripButton_Them.Text = "Thêm";
            this.toolStripButton_Them.Click += new System.EventHandler(this.toolStripButton_Them_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Them,
            this.toolStripButton_Xoa,
            this.toolStripButton_Luu});
            this.toolStrip1.Location = new System.Drawing.Point(395, 11);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(359, 42);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txt_TrieuChung
            // 
            this.txt_TrieuChung.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrieuChung.Location = new System.Drawing.Point(200, 250);
            this.txt_TrieuChung.Name = "txt_TrieuChung";
            this.txt_TrieuChung.Size = new System.Drawing.Size(693, 39);
            this.txt_TrieuChung.TabIndex = 36;
            // 
            // GV_BenhVatNuoi
            // 
            this.GV_BenhVatNuoi.AllowUserToOrderColumns = true;
            this.GV_BenhVatNuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BenhVatNuoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenh,
            this.TenBenh,
            this.TrieuChungBenh,
            this.NguyenNhanBenh,
            this.CachDieuTri});
            this.GV_BenhVatNuoi.Location = new System.Drawing.Point(0, 528);
            this.GV_BenhVatNuoi.Name = "GV_BenhVatNuoi";
            this.GV_BenhVatNuoi.RowHeadersWidth = 82;
            this.GV_BenhVatNuoi.RowTemplate.Height = 33;
            this.GV_BenhVatNuoi.Size = new System.Drawing.Size(2147, 405);
            this.GV_BenhVatNuoi.TabIndex = 28;
            this.GV_BenhVatNuoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BenhVatNuoi_CellContentClick);
            // 
            // MaBenh
            // 
            this.MaBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaBenh.DataPropertyName = "MaBenh";
            this.MaBenh.HeaderText = "Mã Bệnh";
            this.MaBenh.MinimumWidth = 10;
            this.MaBenh.Name = "MaBenh";
            this.MaBenh.Width = 50;
            // 
            // TenBenh
            // 
            this.TenBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenBenh.DataPropertyName = "TenBenh";
            this.TenBenh.HeaderText = "Tên Bệnh";
            this.TenBenh.MinimumWidth = 10;
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.Width = 200;
            // 
            // TrieuChungBenh
            // 
            this.TrieuChungBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrieuChungBenh.DataPropertyName = "TrieuChungBenh";
            this.TrieuChungBenh.HeaderText = "Triệu Chứng";
            this.TrieuChungBenh.MinimumWidth = 10;
            this.TrieuChungBenh.Name = "TrieuChungBenh";
            this.TrieuChungBenh.Width = 420;
            // 
            // NguyenNhanBenh
            // 
            this.NguyenNhanBenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NguyenNhanBenh.DataPropertyName = "NguyenNhanBenh";
            this.NguyenNhanBenh.HeaderText = "Nguyên Nhân";
            this.NguyenNhanBenh.MinimumWidth = 10;
            this.NguyenNhanBenh.Name = "NguyenNhanBenh";
            this.NguyenNhanBenh.Width = 420;
            // 
            // CachDieuTri
            // 
            this.CachDieuTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CachDieuTri.DataPropertyName = "CachDieuTri";
            this.CachDieuTri.HeaderText = "Cách Điều Trị";
            this.CachDieuTri.MinimumWidth = 10;
            this.CachDieuTri.Name = "CachDieuTri";
            this.CachDieuTri.Width = 400;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cách Điều Trị:";
            // 
            // txt_CachDieuTri
            // 
            this.txt_CachDieuTri.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CachDieuTri.Location = new System.Drawing.Point(215, 432);
            this.txt_CachDieuTri.Name = "txt_CachDieuTri";
            this.txt_CachDieuTri.Size = new System.Drawing.Size(1121, 39);
            this.txt_CachDieuTri.TabIndex = 39;
            // 
            // form_BenhVatNuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2144, 932);
            this.Controls.Add(this.txt_CachDieuTri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NguyenNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenBenh);
            this.Controls.Add(this.txt_MaBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_TrieuChung);
            this.Controls.Add(this.GV_BenhVatNuoi);
            this.Name = "form_BenhVatNuoi";
            this.Text = "BenhVatNuoi";
            this.Load += new System.EventHandler(this.form_BenhVatNuoi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BenhVatNuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NguyenNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenBenh;
        private System.Windows.Forms.TextBox txt_MaBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.ToolStripButton toolStripButton_Xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_Them;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txt_TrieuChung;
        private System.Windows.Forms.DataGridView GV_BenhVatNuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CachDieuTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChungBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenNhanBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDieuTri;
    }
}