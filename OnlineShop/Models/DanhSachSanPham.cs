using OnlineShop_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class DanhSachSanPham
    {
        public List<SANPHAM> Giays = new List<SANPHAM>();
        public List<SANPHAM> QuanAo = new List<SANPHAM>();
        public List<SANPHAM> ThatLung = new List<SANPHAM>();
        public List<SANPHAM> TuiXach = new List<SANPHAM>();
    }
}