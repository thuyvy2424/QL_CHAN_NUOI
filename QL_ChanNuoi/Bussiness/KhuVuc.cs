using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QL_ChanNuoi.Conection;
using QL_ChanNuoi.Design;

namespace QL_ChanNuoi.Bussiness
{
    class KhuVuc
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

      public DataTable LoadTable(string khuvuc)
        {
            return ketnoi.GetTable("select * from KhuVuc");
        }

        //Hàm thêm 
        public bool Them( string makhuvuc, string tenkhuvuc)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into KhuVuc values ('"+makhuvuc+"',N'" + tenkhuvuc + "')")) == 1)
                return true;
            return false;
        }

        //Hàm xóa 
        public bool Xoa(string makhuvuc)
        {
            if (ketnoi.ExecuteNoneQuery("delete from KhuVuc where Ma_KV = '" + makhuvuc + "'") == 1)
                return true;
            return false;
        }

        // Hàm lưu, sửa
        public bool Luu(string makhuvuc, string tenkhuvuc)
        {
            if (ketnoi.ExecuteNoneQuery(("update KhuVuc set Ten_KV = N'" + tenkhuvuc + "' where Ma_KV = '" + makhuvuc + "'")) == 1)
                return true;
            return false;
        }
    }
}
