using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QL_ChanNuoi.Conection;

namespace QL_ChanNuoi.Bussiness
{
    class BenhVatNuoi
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

        public DataTable LoadTable(string loai)
        {
            return ketnoi.GetTable("select * from BenhVatNuoi");
        }

        //Hàm thêm 
        public bool Them( string tenbenh, string trieuchungbenh, string nguyennhanbenh, string cachdieutri)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into BenhVatNuoi( TenBenh, TrieuChungBenh, NguyenNhanBenh, CachDieuTri ) values ( N'" + tenbenh + "', N'" + trieuchungbenh + "', N'" + nguyennhanbenh+ "', N'" + cachdieutri + "')")) == 1)
                return true;
            return false;
        }

        //Hàm xóa 
        public bool Xoa(string mabenh)
        {
            if (ketnoi.ExecuteNoneQuery("delete from BenhVatNuoi where MaBenh = '" + mabenh + "'") == 1)
                return true;
            return false;
        }

        // Hàm lưu, sửa
        public bool Luu(string mabenh, string tenbenh, string trieuchungbenh, string nguyennhanbenh, string cachdieutri)
        {
            if (ketnoi.ExecuteNoneQuery(("update BenhVatNuoi set TenBenh = N'" + tenbenh + "', TrieuChungBenh= N'" + trieuchungbenh + "',NguyenNhanBenh = N'" + nguyennhanbenh + "',CachDieuTri = N'" + cachdieutri + "' where MaBenh = '" + mabenh + "'")) == 1)
                return true;
            return false;
        }

        
    }
}

