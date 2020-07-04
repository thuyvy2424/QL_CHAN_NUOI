using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QL_ChanNuoi.Bussiness;
using QL_ChanNuoi.Conection;
using QL_ChanNuoi.Design;
using System.Data.SqlClient;

namespace QL_ChanNuoi.Design
{
    public partial class form_NhapVatNuoi : DevExpress.XtraEditors.XtraForm
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        NhapVatNuoi nhapvn = new NhapVatNuoi();
        public form_NhapVatNuoi()
        {
            InitializeComponent();
        }
        public void LoadDL_VatNuoi()
        {
            dataGridView_DanhSachVatNuoi.DataSource = nhapvn.LoadTable_VatNuoi("select * from VatNuoi");
            cbo_GiongVatNuoi.DataSource = nhapvn.Load_GiongVN_Cbo();
            cbo_GiongVatNuoi.DisplayMember = "MaGiong";
            cbo_GiongVatNuoi.ValueMember = "MaGiong";

        }

        public void LoadDL_DanhSachPhieuNhap()
        {
            cbo_NCC.DataSource = nhapvn.Load_NCC_Cbo();
            cbo_NCC.DisplayMember = "Ten_NCC";
            cbo_NCC.ValueMember = "Ma_NCC";
        }
        private void form_NhapVatNuoi_Load(object sender, EventArgs e)
        {
            LoadDL_VatNuoi();
            LoadDL_DanhSachPhieuNhap();
        }
    }
}