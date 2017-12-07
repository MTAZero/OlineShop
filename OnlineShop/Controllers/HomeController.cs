using OnlineShop.Models;
using OnlineShop_Data;
using OnlineShop_Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SANPHAMService sanpham = new SANPHAMService();
            List<SANPHAM> list = (List<SANPHAM>) sanpham.getAll();

            DanhSachSanPham ds = new DanhSachSanPham();
            ds.Giays = list.Where(p => p.LOAISP == 0).ToList();
            ds.QuanAo = list.Where(p => p.LOAISP == 1).ToList();
            ds.ThatLung = list.Where(p => p.LOAISP == 2).ToList();
            ds.TuiXach = list.Where(p => p.LOAISP == 3).ToList();

            return View(ds);
        }

        /// <summary>
        ///  Chi tiết sản phẩm
        /// </summary>
        public ActionResult ChiTiet(int id)
        {
            SANPHAMService sanpham = new SANPHAMService();

            SANPHAM sp = sanpham.getAll().Where(p => p.ID == id).FirstOrDefault();

            return View(sp);
        }
    }
}