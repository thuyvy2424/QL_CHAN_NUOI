namespace QL_ChanNuoi.Design
{
    partial class form_KhuVuc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_KhuVuc));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.txt_TenKhuVuc = new System.Windows.Forms.TextBox();
            this.txt_MaKhuVuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qL_ChanNuoiDataSet = new QL_ChanNuoi.QL_ChanNuoiDataSet();
            this.qLChanNuoiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GV_KhuVuc = new System.Windows.Forms.DataGridView();
            this.Ma_KV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ChanNuoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChanNuoiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_KhuVuc)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(720, 42);
            this.toolStrip1.TabIndex = 17;
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
            // txt_TenKhuVuc
            // 
            this.txt_TenKhuVuc.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhuVuc.Location = new System.Drawing.Point(192, 163);
            this.txt_TenKhuVuc.Name = "txt_TenKhuVuc";
            this.txt_TenKhuVuc.Size = new System.Drawing.Size(455, 39);
            this.txt_TenKhuVuc.TabIndex = 16;
            // 
            // txt_MaKhuVuc
            // 
            this.txt_MaKhuVuc.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhuVuc.Location = new System.Drawing.Point(192, 93);
            this.txt_MaKhuVuc.Name = "txt_MaKhuVuc";
            this.txt_MaKhuVuc.Size = new System.Drawing.Size(455, 39);
            this.txt_MaKhuVuc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Khu Vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Khu Vực:";
            // 
            // qL_ChanNuoiDataSet
            // 
            this.qL_ChanNuoiDataSet.DataSetName = "QL_ChanNuoiDataSet";
            this.qL_ChanNuoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLChanNuoiDataSetBindingSource
            // 
            this.qLChanNuoiDataSetBindingSource.DataSource = this.qL_ChanNuoiDataSet;
            this.qLChanNuoiDataSetBindingSource.Position = 0;
            // 
            // GV_KhuVuc
            // 
            this.GV_KhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_KhuVuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_KV,
            this.Ten_KV,
            this.btn});
            this.GV_KhuVuc.Location = new System.Drawing.Point(0, 280);
            this.GV_KhuVuc.Name = "GV_KhuVuc";
            this.GV_KhuVuc.RowHeadersWidth = 82;
            this.GV_KhuVuc.RowTemplate.Height = 33;
            this.GV_KhuVuc.Size = new System.Drawing.Size(720, 247);
            this.GV_KhuVuc.TabIndex = 18;
            this.GV_KhuVuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_KhuVuc_CellContentClick_1);
            // 
            // Ma_KV
            // 
            this.Ma_KV.DataPropertyName = "Ma_KV";
            this.Ma_KV.HeaderText = "Mã Khu Vực";
            this.Ma_KV.MinimumWidth = 10;
            this.Ma_KV.Name = "Ma_KV";
            this.Ma_KV.Width = 200;
            // 
            // Ten_KV
            // 
            this.Ten_KV.DataPropertyName = "Ten_KV";
            this.Ten_KV.HeaderText = "Tên Khu Vực";
            this.Ten_KV.MinimumWidth = 10;
            this.Ten_KV.Name = "Ten_KV";
            this.Ten_KV.Width = 150;
            // 
            // btn
            // 
            this.btn.HeaderText = "btn";
            this.btn.MinimumWidth = 10;
            this.btn.Name = "btn";
            this.btn.Width = 200;
            // 
            // form_KhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 526);
            this.Controls.Add(this.GV_KhuVuc);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_TenKhuVuc);
            this.Controls.Add(this.txt_MaKhuVuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_KhuVuc";
            this.Text = "KhuVuc";
            this.Load += new System.EventHandler(this.KhuVuc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ChanNuoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLChanNuoiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_KhuVuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Them;
        private System.Windows.Forms.ToolStripButton toolStripButton_Xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.TextBox txt_TenKhuVuc;
        private System.Windows.Forms.TextBox txt_MaKhuVuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource qLChanNuoiDataSetBindingSource;
        private QL_ChanNuoiDataSet qL_ChanNuoiDataSet;
        private System.Windows.Forms.DataGridView GV_KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KV;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
    }
}