using Moneybox.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Moneybox.Client.Controllers
{
    public class HomeController : Controller
    {
        CashBox _cashBox = CashBox.CashInitializer();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMoney(string sum)
        {
            _cashBox.Money += double.Parse(sum);
            return PartialView(_cashBox);
        }
    }
}