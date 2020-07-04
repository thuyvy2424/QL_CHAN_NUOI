using System;
using DevExpress.Xpo;
using QL_ChanNuoi.Conection;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace QL_ChanNuoi.Bussiness
{

    public class NhapVatNuoi : XPObject
    {
        public NhapVatNuoi() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public NhapVatNuoi(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        ThuVienKetNoi ketnoi = new ThuVienKetNoi();
        public object Load_GiongVN_Cbo()
        {
            return ketnoi.GetTable("select TenGiong from GiongVatNuoi");
        }
        public object Load_NCC_Cbo()
        {
            return ketnoi.GetTable("select Ten_NCC from NhaCungCap");
        }
        public DataTable LoadTable(string loai)
        {
            return ketnoi.GetTable("select * from PhieuNhapVatNuoi");
        }

        public DataTable LoadTable_PhieuNhapChuaNhap (string pn)
        {
            return ketnoi.GetTable("");
        }
       public bool Them(string maphieunhap, DateTime ngaynhap, string magiong, int mancc, int soluong, int dongia, int thanhtien)
        {
            if (ketnoi.ExecuteNoneQuery(("insert into PhieuNhapVatNuoi( MaPhieuNhap_VN, NgayNhap_VN, MaGiong, Ma_NCC, SoLuongNhap_VN, DonGiaNhap_VN, ThanhTienNhap_VN)) values ( N'" + maphieunhap + "', N'" + ngaynhap + "', N'" + magiong + "', N'" + mancc+ "', N'" + soluong + "', N'" + dongia + "', N'" + thanhtien + "'")) == 1)
                return true;
            return false;
        }

         //Hàm xóa 
         public bool Xoa(string MaPhieuNhap_VN)
         {
             if (ketnoi.ExecuteNoneQuery("delete from PhieuNhapVatNuoi where MaPhieuNhap_VN = '" + MaPhieuNhap_VN + "'") == 1)
                 return true;
             return false;
         }

         // Hàm lưu, sửa
         public bool Luu(string MaPhieuNhap_VN, DateTime ngaynhap, string magiong, int mancc, int soluong, int dongia, int thanhtien)
         {
             if (ketnoi.ExecuteNoneQuery(("update PhieuNhapVatNuoi set  NgayNhap_VN= N'" + ngaynhap + "',MaGiong= N'" + magiong + "',Ma_NCC = N'" + mancc+ "', SoLuongNhap_VN = N'" + soluong + "', DonGiaNhap_VN = N'" + dongia + "', ThanhTienNhap_VN = N'" + thanhtien + "' where MaPhieuNhap_VN = '" + MaPhieuNhap_VN + "'")) == 1)
                 return true;
             return false;
         }
    }

}