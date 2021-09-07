using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ptpmqldiep.Controllers
{
    public class DbcontextController : Controller
    {
        giaiphuongtrinh gpt = new giaiphuongtrinh();
        // GET: Dbcontext
        public ActionResult Index()
        {
            return View();
        }
   [HttpPost] 
        public ActionResult Index(string soA , string soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double gtx = giaiphuongtrinh.Index(so1,so2);

            ViewBag.ketqua = gtx;
            return View();
        }
    }
}