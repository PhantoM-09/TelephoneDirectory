using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelephoneDirectory.Models;

namespace TelephoneDirectory.Controllers
{
    public class DictController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<PhoneRecord> phoneRecords = PhoneRecordStorage.GetCollection();

            ViewBag.PhoneRecords = phoneRecords;
            return View();
        }


    }
}