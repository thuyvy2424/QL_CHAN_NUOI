using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_ChanNuoi.Bussiness;
using QL_ChanNuoi.Conection;


namespace QL_ChanNuoi.Design
{
    public partial class form_KhuVuc : Form
    {
        public form_KhuVuc()
        {
            InitializeComponent();
        }
        KhuVuc kv = new KhuVuc();
        ThuVienKetNoi kn = new ThuVienKetNoi();
        /*SqlCommandBuilder sqlCommand = null;

        SqlDataAdapter sqlAdapter = null;

        DataSet dataset = null;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7BVIHS4\\SQLDEV2019;Initial Catalog=QL_ChanNuoi;User ID=sa;password=123456;");
        */
        public void LoadDL()
        {   
            
            
           GV_KhuVuc.DataSource = kv.LoadTable("select * from KhuVuc");
           /* try
            {
                sqlAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM KhuVuc", con);
                sqlCommand = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.UpdateCommand = sqlCommand.GetUpdateCommand();
                sqlAdapter.DeleteCommand = sqlCommand.GetDeleteCommand();
                dataset = new DataSet();
                sqlAdapter.Fill(dataset, "KhuVuc");
                GV_KhuVuc.DataSource = null;
                GV_KhuVuc.DataSource = dataset.Tables["KhuVuc"];
                GV_KhuVuc.DataSource = dataset.Tables["KhuVuc"];
                for (int i = 0; i < GV_KhuVuc.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    GV_KhuVuc[2, i] = linkCell;
                }
            }
    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
        private void KhuVuc_Load(object sender, EventArgs e)
        {
           // con.Open(); 
            LoadDL();
            
        }

        private void toolStripButton_Them_Click(object sender, EventArgs e)
        {
            
            if (kv.Them(txt_MaKhuVuc.Text.Trim(), txt_TenKhuVuc.Text.Trim()))
            {
                MessageBox.Show("Thêm thành công");
                LoadDL();
            }
                
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaKhuVuc.Clear();
            txt_TenKhuVuc.Clear();

        }

        private void toolStripButton_Xoa_Click(object sender, EventArgs e)
        {
            if (kv.Xoa(GV_KhuVuc.CurrentRow.Cells[0].Value.ToString().Trim()))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadDL();
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (kv.Luu(txt_MaKhuVuc.Text.Trim(), txt_TenKhuVuc.Text.Trim()))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadDL();

        }

       

        private void GV_KhuVuc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            toolStripButton_Luu.Enabled = true;
            toolStripButton_Xoa.Enabled = true;
            txt_MaKhuVuc.Text = Convert.ToString(GV_KhuVuc.CurrentRow.Cells["Ma_KV"].Value);
            txt_TenKhuVuc.Text = Convert.ToString(GV_KhuVuc.CurrentRow.Cells["Ten_KV"].Value);

        }



        /* private void GV_KhuVuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             try
             {
                 if (e.ColumnIndex == 2)
                 {
                     string Task = GV_KhuVuc.Rows[e.RowIndex].Cells[2].Value.ToString();
                     if (Task == "Delete")
                     {
                         if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                         {
                             int rowIndex = e.RowIndex;
                             GV_KhuVuc.Rows.RemoveAt(rowIndex);
                             dataset.Tables["KhuVuc"].Rows[rowIndex].Delete();
                             sqlAdapter.Update(dataset, "KhuVuc");
                         }
                     }
                    else if (Task == "Insert")
                     {
                         int row = GV_KhuVuc.Rows.Count -2;
                         DataRow dr = dataset.Tables["KhuVuc"].NewRow();
                         dr["Ma_KV"] = GV_KhuVuc.Rows[row].Cells["Ma_KV"].Value;
                         dr["Ten_KV"] = GV_KhuVuc.Rows[row].Cells["Ten_KV"].Value;
                         dataset.Tables["KhuVuc"].Rows.Add(dr);
                         dataset.Tables["KhuVuc"].Rows.RemoveAt(dataset.Tables["KhuVuc"].Rows.Count - 1);
                         GV_KhuVuc.Rows.RemoveAt(GV_KhuVuc.Rows.Count );
                         GV_KhuVuc.Rows[e.RowIndex].Cells[2].Value = "Delete";
                         sqlAdapter.Update(dataset, "KhuVuc");
                     }
                     else if (Task == "Update")
                     {
                         int r = e.RowIndex;
                         dataset.Tables["KhuVuc"].Rows[r]["Ma_KV"] = GV_KhuVuc.Rows[r].Cells["Ma_KV"].Value;
                         dataset.Tables["KhuVuc"].Rows[r]["Ten_KV"] = GV_KhuVuc.Rows[r].Cells["Ten_KV"].Value;

                         sqlAdapter.Update(dataset, "KhuVuc");
                         GV_KhuVuc.Rows[e.RowIndex].Cells[2].Value = "Delete";
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
    }

