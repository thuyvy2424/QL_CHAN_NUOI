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
    public partial class form_NhaCungCap : Form
    {
        public form_NhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        public void LoadDL()
        {
            GV_NCC.DataSource = ncc.LoadTable("Select * from NhaCungCap");
        }
        private void Form_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void toolStripButton_Them_Click(object sender, EventArgs e)
        {
            if (ncc.Them(txt_TenNCC.Text.Trim(), txt_SDT.Text.Trim(), txt_email.Text.Trim(), txt_DiaChi.Text.Trim(), txt_LoaiNCC.Text.Trim()))
            {
                MessageBox.Show("Thêm thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void toolStripButton_Xoa_Click(object sender, EventArgs e)
        {
            if (ncc.Xoa(GV_NCC.CurrentRow.Cells[0].Value.ToString().Trim()))
            {
                MessageBox.Show("Xóa thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

      /*  private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (ncc.Luu(txt_TenNCC.Text.Trim(),txt_SDT.Text.Trim(),txt_email.Text.Trim(),txt_DiaChi.Text.Trim(),txt_LoaiNCC.Text.Trim()))
            {
                MessageBox.Show("Lưu thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Lưu thất bại");
        }*/
    }
}
