namespace QL_ChanNuoi.Design
{
    partial class form_GiongVatNuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_GiongVatNuoi));
            this.GV_GiongVatNuoi = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.txt_TenGiong = new System.Windows.Forms.TextBox();
            this.txt_MaGiong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaGiong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GV_GiongVatNuoi)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_GiongVatNuoi
            // 
            this.GV_GiongVatNuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_GiongVatNuoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiong,
            this.TenGiong});
            this.GV_GiongVatNuoi.Location = new System.Drawing.Point(-2, 260);
            this.GV_GiongVatNuoi.Name = "GV_GiongVatNuoi";
            this.GV_GiongVatNuoi.RowHeadersWidth = 82;
            this.GV_GiongVatNuoi.RowTemplate.Height = 33;
            this.GV_GiongVatNuoi.Size = new System.Drawing.Size(790, 455);
            this.GV_GiongVatNuoi.TabIndex = 6;
            this.GV_GiongVatNuoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_GiongVatNuoi_CellContentClick);
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
            this.toolStrip1.Size = new System.Drawing.Size(788, 42);
            this.toolStrip1.TabIndex = 11;
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
            // txt_TenGiong
            // 
            this.txt_TenGiong.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenGiong.Location = new System.Drawing.Point(157, 179);
            this.txt_TenGiong.Name = "txt_TenGiong";
            this.txt_TenGiong.Size = new System.Drawing.Size(488, 39);
            this.txt_TenGiong.TabIndex = 10;
            // 
            // txt_MaGiong
            // 
            this.txt_MaGiong.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGiong.Location = new System.Drawing.Point(157, 101);
            this.txt_MaGiong.Name = "txt_MaGiong";
            this.txt_MaGiong.Size = new System.Drawing.Size(488, 39);
            this.txt_MaGiong.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Giống:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Giống:";
            // 
            // MaGiong
            // 
            this.MaGiong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaGiong.DataPropertyName = "MaGiong";
            this.MaGiong.HeaderText = "Mã Giống";
            this.MaGiong.MinimumWidth = 10;
            this.MaGiong.Name = "MaGiong";
            // 
            // TenGiong
            // 
            this.TenGiong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenGiong.DataPropertyName = "TenGiong";
            this.TenGiong.HeaderText = "Tên Giống";
            this.TenGiong.MinimumWidth = 10;
            this.TenGiong.Name = "TenGiong";
            this.TenGiong.Width = 200;
            // 
            // form_GiongVatNuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 714);
            this.Controls.Add(this.GV_GiongVatNuoi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_TenGiong);
            this.Controls.Add(this.txt_MaGiong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_GiongVatNuoi";
            this.Text = "GiongVatNuoi";
            this.Load += new System.EventHandler(this.form_GiongVatNuoi_Load);
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
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.TextBox txt_TenGiong;
        private System.Windows.Forms.TextBox txt_MaGiong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiong;
    }
}