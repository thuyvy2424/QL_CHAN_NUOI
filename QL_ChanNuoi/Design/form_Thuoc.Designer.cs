namespace QL_ChanNuoi.Design
{
    partial class form_Thuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Thuoc));
            this.GV_GiongVatNuoi = new System.Windows.Forms.DataGridView();
            this.SoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.txt_MaThuoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenThuoc = new System.Windows.Forms.TextBox();
            this.txt_CongDung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_GiongVatNuoi)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_GiongVatNuoi
            // 
            this.GV_GiongVatNuoi.AllowUserToOrderColumns = true;
            this.GV_GiongVatNuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_GiongVatNuoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoTT,
            this.Barcode,
            this.TenThuoc,
            this.CongDung});
            this.GV_GiongVatNuoi.Location = new System.Drawing.Point(0, 400);
            this.GV_GiongVatNuoi.Name = "GV_GiongVatNuoi";
            this.GV_GiongVatNuoi.RowHeadersWidth = 82;
            this.GV_GiongVatNuoi.RowTemplate.Height = 33;
            this.GV_GiongVatNuoi.Size = new System.Drawing.Size(1237, 246);
            this.GV_GiongVatNuoi.TabIndex = 18;
            // 
            // SoTT
            // 
            this.SoTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTT.HeaderText = "Mã Thuốc";
            this.SoTT.MinimumWidth = 10;
            this.SoTT.Name = "SoTT";
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 10;
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 200;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 10;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 350;
            // 
            // CongDung
            // 
            this.CongDung.HeaderText = "Công dụng";
            this.CongDung.MinimumWidth = 10;
            this.CongDung.Name = "CongDung";
            this.CongDung.Width = 420;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Them,
            this.toolStripButton_Xoa,
            this.toolStripButton_Sua,
            this.toolStripButton_Luu});
            this.toolStrip1.Location = new System.Drawing.Point(396, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(387, 42);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Them
            // 
            this.toolStripButton_Them.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Them.Image")));
            this.toolStripButton_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Them.Name = "toolStripButton_Them";
            this.toolStripButton_Them.Size = new System.Drawing.Size(112, 36);
            this.toolStripButton_Them.Text = "Thêm";
            // 
            // toolStripButton_Xoa
            // 
            this.toolStripButton_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Xoa.Image")));
            this.toolStripButton_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Xoa.Name = "toolStripButton_Xoa";
            this.toolStripButton_Xoa.Size = new System.Drawing.Size(91, 36);
            this.toolStripButton_Xoa.Text = "Xóa";
            // 
            // toolStripButton_Sua
            // 
            this.toolStripButton_Sua.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Sua.Image")));
            this.toolStripButton_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sua.Name = "toolStripButton_Sua";
            this.toolStripButton_Sua.Size = new System.Drawing.Size(90, 36);
            this.toolStripButton_Sua.Text = "Sửa";
            // 
            // toolStripButton_Luu
            // 
            this.toolStripButton_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Luu.Image")));
            this.toolStripButton_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Luu.Name = "toolStripButton_Luu";
            this.toolStripButton_Luu.Size = new System.Drawing.Size(90, 36);
            this.toolStripButton_Luu.Text = "Lưu";
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Barcode.Location = new System.Drawing.Point(193, 159);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(276, 39);
            this.txt_Barcode.TabIndex = 22;
            // 
            // txt_MaThuoc
            // 
            this.txt_MaThuoc.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaThuoc.Location = new System.Drawing.Point(193, 89);
            this.txt_MaThuoc.Name = "txt_MaThuoc";
            this.txt_MaThuoc.Size = new System.Drawing.Size(213, 39);
            this.txt_MaThuoc.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Barcode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên Thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Công Dụng:";
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenThuoc.Location = new System.Drawing.Point(193, 250);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Size = new System.Drawing.Size(605, 39);
            this.txt_TenThuoc.TabIndex = 26;
            // 
            // txt_CongDung
            // 
            this.txt_CongDung.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CongDung.Location = new System.Drawing.Point(193, 336);
            this.txt_CongDung.Name = "txt_CongDung";
            this.txt_CongDung.Size = new System.Drawing.Size(803, 39);
            this.txt_CongDung.TabIndex = 27;
            // 
            // Thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 643);
            this.Controls.Add(this.txt_CongDung);
            this.Controls.Add(this.txt_TenThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GV_GiongVatNuoi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_Barcode);
            this.Controls.Add(this.txt_MaThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Thuoc";
            this.Text = "Thuoc";
            ((System.ComponentModel.ISupportInitialize)(this.GV_GiongVatNuoi)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_GiongVatNuoi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Them;
        private System.Windows.Forms.ToolStripButton toolStripButton_Xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sua;
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.TextBox txt_MaThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenThuoc;
        private System.Windows.Forms.TextBox txt_CongDung;
    }
}