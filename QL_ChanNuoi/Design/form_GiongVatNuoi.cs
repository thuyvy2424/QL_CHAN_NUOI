using QL_ChanNuoi.Bussiness;
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

namespace QL_ChanNuoi.Design
{
    public partial class form_GiongVatNuoi : Form
    {
        public form_GiongVatNuoi()
        {
            InitializeComponent();
        }
        GiongVatNuoi gvn = new GiongVatNuoi();
        public void LoadDL()
        {
            GV_GiongVatNuoi.DataSource = gvn.LoadTable("Select * from GiongVatNuoi");
        }
        private void toolStripButton_Them_Click(object sender, EventArgs e)
        {
            
            if (gvn.Them(txt_MaGiong.Text.Trim(), txt_TenGiong.Text.Trim()))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            LoadDL();
            txt_MaGiong.Clear();
            txt_TenGiong.Clear();
        }

        private void form_GiongVatNuoi_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void toolStripButton_Xoa_Click(object sender, EventArgs e)
        {
            if (gvn.Xoa(GV_GiongVatNuoi.CurrentRow.Cells[0].Value.ToString().Trim()))
            {
                MessageBox.Show("Xóa thành công");
                LoadDL();
            }
            else
                MessageBox.Show("Xóa thất bại");
            
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {

            if (gvn.Luu(txt_MaGiong.Text.Trim(), txt_TenGiong.Text.Trim()))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadDL();
        }

        private void GV_GiongVatNuoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   

            toolStripButton_Xoa.Enabled = true;
            toolStripButton_Luu.Enabled = true;
            txt_MaGiong.Text = Convert.ToString (GV_GiongVatNuoi.CurrentRow.Cells["MaGiong"].Value);
            txt_TenGiong.Text = Convert.ToString(GV_GiongVatNuoi.CurrentRow.Cells["TenGiong"].Value);
         
        }
    }
}
