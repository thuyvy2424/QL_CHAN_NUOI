using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QL_ChanNuoi.Bussiness;
using QL_ChanNuoi.Design;

namespace QL_ChanNuoi.Conection
{
    class ThuVienKetNoi
    {//Khởi tạo các biến để Contect tới Dataset
        static SqlConnection VG_Connection;
        SqlDataAdapter VG_DataAdapter;
        SqlCommand VG_SqlCommand;

        public static string VG_StringConnection = "Data Source=DESKTOP-7BVIHS4\\SQLDEV2019;Initial Catalog=QL_ChanNuoi;User ID=sa;password=123456;";

        // Hàm mở Connection lên, nếu mở thành công thì trả về True
        public static bool OpenConnection()
        {
            try
            {
                if (VG_Connection == null)
                    VG_Connection = new SqlConnection(VG_StringConnection);
                if (VG_Connection.State != ConnectionState.Open)
                    VG_Connection.Open();
                return true;
            }
            catch
            {
                VG_Connection.Close();
                return false;
            }
        }

        //Hàm ExecuteNonQuery tổng quát, trả về số dòng bị ảnh hưởng
        public int ExecuteNoneQuery(string str)
        {

            int result = 0;
            SqlTransaction tr = null;
            //Mở kết nối
            if (OpenConnection())
            {
                try
                {
                    tr = VG_Connection.BeginTransaction();
                    VG_SqlCommand = new SqlCommand(str);
                    VG_SqlCommand.Connection = VG_Connection;
                    VG_SqlCommand.Transaction = tr;
                    result = VG_SqlCommand.ExecuteNonQuery();
                    tr.Commit();
                }
                catch (Exception)
                {
                    if (tr != null) tr.Rollback();
                    tr.Dispose();
                }
                VG_Connection.Close();
                return result;
            }
            return 0;

        }

        //Hàm ExecuteScalar trả về ô đầu tiên
        public object ExecuteScalar(string str)
        {

            object result = null;
            if (OpenConnection())
                try
                {
                    VG_SqlCommand = new SqlCommand(str);
                    VG_SqlCommand.Connection = VG_Connection;
                    result = VG_SqlCommand.ExecuteScalar();
                }
                catch (Exception)
                {
                    VG_Connection.Close();
                    return null;
                }

            VG_Connection.Close();
            return result;
        }

        //Hàm trả về bảng dữ liệu
        public DataTable GetTable(string command)
        {
            VG_SqlCommand = new SqlCommand(command);
            DataTable tb = new DataTable();
            try
            {
                if (OpenConnection())
                {
                    VG_DataAdapter = new SqlDataAdapter(command, VG_Connection);
                    VG_DataAdapter.Fill(tb);
                }
            }
            catch (Exception) { }
            VG_Connection.Close();
            return tb;
        }
    }
}

