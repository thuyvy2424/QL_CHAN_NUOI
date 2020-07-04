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
    class NhaCungCap
    {
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();

        public DataTable LoadTable(string loai)
        {
            return ketnoi.GetTable("select * from NhaCungCap");
        }

        //Hàm thêm 
        public bool Them(string tenncc, string sdt , string email, string diachi, string loai)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into NhaCungCap( Ten_NCC, SoDienThoai_NCC, Email_NCC, DiaChi_NCC, Loai_NCC ) values ( N'" + tenncc + "', N'" + sdt + "', N'" + email + "', N'" + diachi + "', N'" + loai + "')")) == 1)
                return true;
            return false;
        }

        //Hàm xóa 
        public bool Xoa(string mancc)
        {
            if (ketnoi.ExecuteNoneQuery("delete from NhaCungCap where Ma_NCC = '" + mancc + "'") == 1)
                return true;
            return false;
        }

        // Hàm lưu, sửa
        public bool Luu(string mancc, string tenncc, string sdt, string email, string diachi, string loaincc)
        {
            if (ketnoi.ExecuteNoneQuery(("update NhaCungCap set Ten_NCC= N'" + tenncc + "', SoDienThoai_NCC= N'" + sdt + "', Email_NCC= N'" + email + "', DiaChi_NCC = N'" + diachi + "', Loai_NCC= N'" + loaincc + "' where Ma_NCC= '"+mancc+"' ")) == 1)
                return true;
            return false;
        }
    }
}
