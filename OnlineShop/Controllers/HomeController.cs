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

            return View(list);
        }
    }
}