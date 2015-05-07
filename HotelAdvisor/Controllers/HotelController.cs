using HotelAdvisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAdvisor.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {

            HotelAdvisorContext context = new HotelAdvisorContext();
            var model = context.Hotels.ToList();

            return View(model);
        }
    }
}