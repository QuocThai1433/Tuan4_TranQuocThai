using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan4_TranQuocThai.Models;
using PagedList;
namespace Tuan4_TranQuocThai.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext dt = new MyDataDataContext();
        // GET: Home
        public ActionResult Index( int ? page)
        {
            if (page == null) page = 1;
            var all_sachhome = (from ss in dt.Saches select ss).OrderBy(m=>m.masach);
            int pageSize = 2;
            int pageNum = page ?? 1;
            return View(all_sachhome.ToPagedList(pageNum,pageSize));
        }
    }
}