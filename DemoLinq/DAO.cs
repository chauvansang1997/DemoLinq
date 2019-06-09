using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoLinq
{
    public static class DAO
    {
        public static List<KhachHang> LayDanhSachKhachHang()
        {
            using (dbKaoraokeDataContext dataContext = new dbKaoraokeDataContext())
            {
                var list = (from khachHang in dataContext.KHACHHANGs
                            select new KhachHang()
                            {
                                MaKhachHang = khachHang.MAKH,
                                LoaiKhachHang = khachHang.LOAIKHACHHANG.TENLOAIKH,
                                SoDienThoai = khachHang.SDT,
                                TenKhachHang = khachHang.TENKH
                            }).ToList();

                return list;
            }
        }
    }
}
