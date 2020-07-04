namespace QL_ChanNuoi.Design
{
    partial class form_NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_NhaCungCap));
            this.GV_NCC = new System.Windows.Forms.DataGridView();
            this.Ma_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.txt_LoaiNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV_NCC)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_NCC
            // 
            this.GV_NCC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GV_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NCC,
            this.Ten_NCC,
            this.Email_NCC,
            this.SoDienThoai_NCC,
            this.Diachi_NCC,
            this.Loai_NCC});
            this.GV_NCC.Location = new System.Drawing.Point(-9, 370);
            this.GV_NCC.Name = "GV_NCC";
            this.GV_NCC.RowHeadersWidth = 82;
            this.GV_NCC.RowTemplate.Height = 33;
            this.GV_NCC.Size = new System.Drawing.Size(1593, 438);
            this.GV_NCC.TabIndex = 0;
            // 
            // Ma_NCC
            // 
            this.Ma_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ma_NCC.DataPropertyName = "Ma_NCC";
            this.Ma_NCC.HeaderText = "Mã nhà cung cấp";
            this.Ma_NCC.MinimumWidth = 10;
            this.Ma_NCC.Name = "Ma_NCC";
            this.Ma_NCC.Width = 200;
            // 
            // Ten_NCC
            // 
            this.Ten_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ten_NCC.DataPropertyName = "Ten_NCC";
            this.Ten_NCC.HeaderText = "Tên nhà cung cấp";
            this.Ten_NCC.MinimumWidth = 10;
            this.Ten_NCC.Name = "Ten_NCC";
            this.Ten_NCC.Width = 250;
            // 
            // Email_NCC
            // 
            this.Email_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email_NCC.DataPropertyName = "Email_NCC";
            this.Email_NCC.HeaderText = "Email";
            this.Email_NCC.MinimumWidth = 10;
            this.Email_NCC.Name = "Email_NCC";
            this.Email_NCC.Width = 150;
            // 
            // SoDienThoai_NCC
            // 
            this.SoDienThoai_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoDienThoai_NCC.DataPropertyName = "SoDienThoai_NCC";
            this.SoDienThoai_NCC.HeaderText = "Số điện thoại";
            this.SoDienThoai_NCC.MinimumWidth = 10;
            this.SoDienThoai_NCC.Name = "SoDienThoai_NCC";
            this.SoDienThoai_NCC.Width = 150;
            // 
            // Diachi_NCC
            // 
            this.Diachi_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Diachi_NCC.DataPropertyName = "Diachi_NCC";
            this.Diachi_NCC.HeaderText = "Địa chỉ";
            this.Diachi_NCC.MinimumWidth = 10;
            this.Diachi_NCC.Name = "Diachi_NCC";
            this.Diachi_NCC.Width = 250;
            // 
            // Loai_NCC
            // 
            this.Loai_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Loai_NCC.DataPropertyName = "Loai_NCC";
            this.Loai_NCC.HeaderText = "Loại nhà cung cấp";
            this.Loai_NCC.MinimumWidth = 10;
            this.Loai_NCC.Name = "Loai_NCC";
            this.Loai_NCC.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Them,
            this.toolStripButton_Xoa,
            this.toolStripButton_Luu});
            this.toolStrip1.Location = new System.Drawing.Point(787, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(297, 42);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButton_Luu
            // 
            this.toolStripButton_Luu.Enabled = false;
            this.toolStripButton_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Luu.Image")));
            this.toolStripButton_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Luu.Name = "toolStripButton_Luu";
            this.toolStripButton_Luu.Size = new System.Drawing.Size(90, 36);
            this.toolStripButton_Luu.Text = "Lưu";
//            this.toolStripButton_Luu.Click += new System.EventHandler(this.toolStripButton_Luu_Click);
            // 
            // txt_LoaiNCC
            // 
            this.txt_LoaiNCC.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiNCC.Location = new System.Drawing.Point(899, 180);
            this.txt_LoaiNCC.Name = "txt_LoaiNCC";
            this.txt_LoaiNCC.Size = new System.Drawing.Size(611, 39);
            this.txt_LoaiNCC.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(719, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Loại NCC:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(227, 313);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(1325, 39);
            this.txt_DiaChi.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tên NCC:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(227, 172);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(308, 39);
            this.txt_SDT.TabIndex = 43;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Enabled = false;
            this.txt_MaNCC.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNCC.Location = new System.Drawing.Point(227, 89);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(301, 39);
            this.txt_MaNCC.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã NCC:";
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNCC.Location = new System.Drawing.Point(899, 91);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(653, 39);
            this.txt_TenNCC.TabIndex = 46;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(227, 246);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(612, 39);
            this.txt_email.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 31);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email:";
            // 
            // form_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 831);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_LoaiNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_MaNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenNCC);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GV_NCC);
            this.Name = "form_NhaCungCap";
            this.Text = "Form_NhaCungCap";
            this.Load += new System.EventHandler(this.Form_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_NCC)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_NCC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Them;
        private System.Windows.Forms.ToolStripButton toolStripButton_Xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_NCC;
        private System.Windows.Forms.TextBox txt_LoaiNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
    }
}