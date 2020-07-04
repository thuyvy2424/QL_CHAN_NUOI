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
    class LoaiVacxin
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

        public DataTable LoadTable(string loai)
        {
            return ketnoi.GetTable("select * from LoaiVacxin");
        }

        //Hàm thêm 
        public bool Them(string maloai, string tenloai)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into LoaiVacxin values ('" + maloai + "',N'" + tenloai + "')")) == 1)
                return true;
            return false;
        }

        //Hàm xóa 
        public bool Xoa(string maloai)
        {
            if (ketnoi.ExecuteNoneQuery("delete from LoaiVacxin where MaGiong = '" + maloai + "'") == 1)
                return true;
            return false;
        }

        // Hàm lưu, sửa
        public bool Luu(string maloai, string tenloai)
        {
            if (ketnoi.ExecuteNoneQuery(("update LoaiVacxin set Ten_LoaiVX = N'" + tenloai + "' where Ma_LoaiVX = '" + maloai + "'")) == 1)
                return true;
            return false;
        }
    }
}
