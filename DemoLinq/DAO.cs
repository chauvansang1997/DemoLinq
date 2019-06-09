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

        public static List<HoaDon> LayDanhSachHoaDon()
        {
            using (dbKaoraokeDataContext dataContext = new dbKaoraokeDataContext())
            {
                var list = (from hoaDon in dataContext.HOADONs
                            select new HoaDon()
                            {
                                MaKhachHang = hoaDon.MAKH,
                                SoHoaDon = hoaDon.SOHD,
                                GiamGia = hoaDon.GIAMGIA.HasValue ? hoaDon.GIAMGIA.Value : 0,
                                GioVao = hoaDon.GIOVAO.HasValue ? hoaDon.GIOVAO.Value : DateTime.Now,
                                GioRa = hoaDon.GIORA.HasValue ? hoaDon.GIORA.Value : DateTime.Now,
                                MaPhong = hoaDon.MAPHONG,
                                NgayLap = hoaDon.NGAYLAP.HasValue ? hoaDon.NGAYLAP.Value : DateTime.Now,
                                ThanhTien = hoaDon.THANHTIEN.HasValue ? hoaDon.THANHTIEN.Value : 0,
                                TienGio = hoaDon.TIENGIO.HasValue ? hoaDon.TIENGIO.Value : 0,
                                TrangThai = hoaDon.TRANGTHAI.HasValue ? hoaDon.TRANGTHAI.Value : 0
                            }).ToList();

                return list;
            }
        }
    }
}
