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
    class GiongVatNuoi
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

          public DataTable LoadTable(string khuvuc)
        {
            return ketnoi.GetTable("select * from GiongVatNuoi");
        }

        //Hàm thêm 
        public bool Them(string magiong, string tengiong)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into GiongVatNuoi values ('" + magiong + "',N'" + tengiong + "')")) == 1)
                return true;
            return false;
        }

        //Hàm xóa 
        public bool Xoa(string magiong)
        {
            if (ketnoi.ExecuteNoneQuery("delete from GiongVatNuoi where MaGiong = '" + magiong + "'") == 1)
                return true;
            return false;
        }

        // Hàm lưu, sửa
        public bool Luu(string magiong, string tengiong)
        {
            if (ketnoi.ExecuteNoneQuery(("update GiongVatNuoi set TenGiong = N'" + tengiong + "' where MaGiong = '" + magiong + "'")) == 1)
                return true;
            return false;
        }
    }
}

