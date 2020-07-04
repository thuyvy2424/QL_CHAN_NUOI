using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_ChanNuoi.Conection;
using QL_ChanNuoi.Bussiness;

namespace QL_ChanNuoi.Design
{
    public partial class form_BenhVatNuoi : Form
    {
        ThuVienKetNoi ketNoi = new ThuVienKetNoi();
        BenhVatNuoi bvn = new BenhVatNuoi();
        public form_BenhVatNuoi()
        {
            InitializeComponent();
        }
        public void LoadDL()
        {
            GV_BenhVatNuoi.DataSource = bvn.LoadTable("Select * from BenhVatNuoi");
        }
        private void toolStripButton_Them_Click(object sender, EventArgs e)

        {
            if (bvn.Them(txt_TenBenh.Text.Trim(), txt_NguyenNhan.Text.Trim(), txt_TrieuChung.Text.Trim(), txt_CachDieuTri.Text.Trim()))
            {
                MessageBox.Show("Thêm thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void form_BenhVatNuoi_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void GV_BenhVatNuoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton_Luu.Enabled = toolStripButton_Xoa.Enabled = true;
            txt_MaBenh.Text = Convert.ToString(GV_BenhVatNuoi.CurrentRow.Cells["MaBenh"].Value);
            txt_TenBenh.Text = Convert.ToString(GV_BenhVatNuoi.CurrentRow.Cells["TenBenh"].Value);
            txt_TrieuChung.Text= Convert.ToString(GV_BenhVatNuoi.CurrentRow.Cells["TrieuChungBenh"].Value);
            txt_NguyenNhan.Text= Convert.ToString(GV_BenhVatNuoi.CurrentRow.Cells["NguyenNhanBenh"].Value);
            txt_CachDieuTri.Text= Convert.ToString(GV_BenhVatNuoi.CurrentRow.Cells["CachDieuTri"].Value);
        }

        private void toolStripButton_Xoa_Click(object sender, EventArgs e)
        {
            if (bvn.Xoa(GV_BenhVatNuoi.CurrentRow.Cells[0].Value.ToString().Trim()))
            {
                MessageBox.Show("Xóa thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (bvn.Luu(txt_MaBenh.Text.Trim(), txt_TenBenh.Text.Trim(), txt_NguyenNhan.Text.Trim(), txt_TrieuChung.Text.Trim(), txt_CachDieuTri.Text.Trim()))
            {
                MessageBox.Show("Lưu thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Lưu thất bại");
        }
    }
}

