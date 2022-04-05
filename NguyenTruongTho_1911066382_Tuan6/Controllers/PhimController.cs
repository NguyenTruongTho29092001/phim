using NguyenTruongTho_1911066382_Tuan6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenTruongTho_1911066382_Tuan6.Controllers
{
    public class PhimController : Controller
    {
        // GET: Phim
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult ListPhim()
        {
            var all_phim = from ss in data.Phims select ss;
            return View(all_phim);
        }

        public ActionResult LichChieu()
        {
            var all_lichchieu = from ss in data.LichChieus select ss;
            return View(all_lichchieu);
        }

        public ActionResult PhimDangChieu()
        {
            var all_lichchieu = (from ss in data.Phims select ss).Where(n => n.ngaychieu < DateTime.Now);
            return View(all_lichchieu);
        }
        public ActionResult PhimSapChieu()
        {
            var all_psc = (from ss in data.Phims select ss).Where(n => n.ngaychieu >= DateTime.Now);
            return View(all_psc);
        }
    }
}