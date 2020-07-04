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
using QL_ChanNuoi.Bussiness;
using QL_ChanNuoi.Conection;

namespace QL_ChanNuoi.Design
{
    public partial class form_LoaiVacxin : Form
    {
        public form_LoaiVacxin()
        {
            InitializeComponent();
        }
        LoaiVacxin vx = new LoaiVacxin();
        public void LoadDL()
        {
            GV_LoaiVacxin.DataSource = vx.LoadTable("Select * from LoaiVacxin");
        }
        private void form_LoaiVacxin_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void GV_LoaiVacxin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton_Xoa.Enabled = toolStripButton_Luu.Enabled = true;
            txt_MaLoai.Text = GV_LoaiVacxin.CurrentRow.Cells["Ma_LoaiVX"].Value.ToString();
            txt_TenLoai.Text = GV_LoaiVacxin.CurrentRow.Cells["Ten_LoaiVX"].Value.ToString();

        }

        private void toolStripButton_Them_Click(object sender, EventArgs e)
        {
            if (vx.Them(txt_MaLoai.Text.Trim(), txt_TenLoai.Text.Trim()))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            LoadDL();
            txt_MaLoai.Clear();
            txt_TenLoai.Clear();
        }

        private void toolStripButton_Xoa_Click(object sender, EventArgs e)
        {
            if (vx.Xoa(GV_LoaiVacxin.CurrentRow.Cells[0].Value.ToString().Trim()))
            {
                MessageBox.Show("Xóa thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (vx.Luu(txt_MaLoai.Text.Trim(), txt_TenLoai.Text.Trim()))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadDL();
        }
    }
}
