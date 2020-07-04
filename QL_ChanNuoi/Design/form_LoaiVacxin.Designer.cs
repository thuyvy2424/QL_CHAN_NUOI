namespace QL_ChanNuoi.Design
{
    partial class form_LoaiVacxin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LoaiVacxin));
            this.GV_LoaiVacxin = new System.Windows.Forms.DataGridView();
            this.Ma_LoaiVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_LoaiVX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GV_LoaiVacxin)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_LoaiVacxin
            // 
            this.GV_LoaiVacxin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_LoaiVacxin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_LoaiVX,
            this.Ten_LoaiVX});
            this.GV_LoaiVacxin.Location = new System.Drawing.Point(-4, 277);
            this.GV_LoaiVacxin.Name = "GV_LoaiVacxin";
            this.GV_LoaiVacxin.RowHeadersWidth = 82;
            this.GV_LoaiVacxin.RowTemplate.Height = 33;
            this.GV_LoaiVacxin.Size = new System.Drawing.Size(667, 206);
            this.GV_LoaiVacxin.TabIndex = 0;
            this.GV_LoaiVacxin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_LoaiVacxin_CellContentClick);
            // 
            // Ma_LoaiVX
            // 
            this.Ma_LoaiVX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ma_LoaiVX.DataPropertyName = "Ma_LoaiVX";
            this.Ma_LoaiVX.HeaderText = "Mã Loại";
            this.Ma_LoaiVX.MinimumWidth = 10;
            this.Ma_LoaiVX.Name = "Ma_LoaiVX";
            this.Ma_LoaiVX.Width = 150;
            // 
            // Ten_LoaiVX
            // 
            this.Ten_LoaiVX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ten_LoaiVX.DataPropertyName = "Ten_LoaiVX";
            this.Ten_LoaiVX.HeaderText = "Tên Loại Vacxin";
            this.Ten_LoaiVX.MinimumWidth = 10;
            this.Ten_LoaiVX.Name = "Ten_LoaiVX";
            this.Ten_LoaiVX.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại:";
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoai.Location = new System.Drawing.Point(128, 119);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(488, 39);
            this.txt_MaLoai.TabIndex = 3;
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoai.Location = new System.Drawing.Point(128, 196);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(488, 39);
            this.txt_TenLoai.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Them,
            this.toolStripButton_Xoa,
            this.toolStripButton_Luu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 42);
            this.toolStrip1.TabIndex = 5;
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
            this.toolStripButton_Luu.Click += new System.EventHandler(this.toolStripButton_Luu_Click);
            // 
            // form_LoaiVacxin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_TenLoai);
            this.Controls.Add(this.txt_MaLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GV_LoaiVacxin);
            this.Name = "form_LoaiVacxin";
            this.Text = "LoaiVacxin";
            this.Load += new System.EventHandler(this.form_LoaiVacxin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_LoaiVacxin)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_LoaiVacxin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Them;
        private System.Windows.Forms.ToolStripButton toolStripButton_Xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_LoaiVX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_LoaiVX;
    }
}