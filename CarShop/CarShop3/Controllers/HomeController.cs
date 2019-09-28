using CarShop3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShop3.Controllers
{
    public class HomeController : Controller
    {
        private Models.ShopDBModel db = new Models.ShopDBModel();


        // GET: Home
        public ActionResult Index()
        {
            var Items = db.Cars;
            return View(Items);
        }
        public ActionResult CarPage(int item_id)
        {
            var Item = db.Cars.FirstOrDefault(x => x.Id == item_id);
            if (Item == null)
            {
                return Content("<h1>Страница не найдена</h>");
            }
            return View(Item);
        }
        [ChildActionOnly]
        public ActionResult Nav()
        {
            var Items = db.Cars;
            string result = "";
            foreach (var item in Items)
            {
                result += "<li><a href='/Home/CarPage/?item_id="+item.Id+"' title='"+item.Title+"'>"+item.Title+"</a></li>";
            }
            return Content(result);
        }
        [HttpGet]
        public ActionResult Form(int item_id=0)
        {
            ViewBag.Item = item_id;
            return PartialView();
        }
        [ChildActionOnly]
        public string FormOptions(int item_id=0)
        {
            var Items = db.Cars;
            string str = "";
            foreach(var item in Items)
            {
                if (item_id == item.Id)
                {
                    str += "<option value=" + item.Id + " selected>" + item.Title + "</option>";
                }
                else
                {
                    str += "<option value=" + item.Id + ">" + item.Title + "</option>";
                }
            }
            return str;
        }
        [HttpPost]
        public string Form(string Name, string Tel, int Car)
        {
            Order order = new Order
            {
                UserName = Name,
                UserTel = Tel,
                Carld = Car,
                Status = "Создана"
            };
            db.Orders.Add(order);
            db.SaveChanges();
            return "Ваша заявка на автомобиль создана" + db.Cars.FirstOrDefault(x => x.Id == Car).Title + " , была принята";

        }
    }
}