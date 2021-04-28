using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_3.Models;

namespace ASP_3.Controllers
{
    public class HomeController : Controller
    {
        LIMUPAStoreEntities db = new LIMUPAStoreEntities();
        public ActionResult Index()
        {
            return View(db.PRODUCTs.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetNewArrival()
        {

        }
        public ActionResult GetBestSeller()
        {
            int year = DateTime.Now.Year;
            List<int> count = new List<int>();
            List<string> id = new List<string>();
            foreach(var item in db.PRODUCTs.ToList())
            {
                count.Add(0);
                id.Add(item.PRODUCT_ID);
            }
            foreach (var item in db.CARTDETAILs)
            {
                // Convert part
                //int year = getYear(item.CART.)
                // Thiếu create date trong Card, cần backup lại dữ liệu từ file txt
                int key = id.FindIndex(x => x == item.PRODUCT_ID);
                count[key]++;
            }
            List<PRODUCT> result = new List<PRODUCT>();
            for(int i = 0; i < id.Count; i++)
            {
                if(i == 7)
                {
                    break;
                }
                int key = findMax(count);
                var currentProduct = db.PRODUCTs.Where(p => p.PRODUCT_ID == id[key]).FirstOrDefault();
                result.Add(currentProduct);
                count.RemoveAt(key);
                id.RemoveAt(key);
            }
            return PartialView(result);
        }
        private int getYear(string date)
        {
            return int.Parse(date.Substring(6, date.Length - 1));
        }
        private int findMax(List<int> data)
        {
            int max = 0;
            int location = 0;
            for(int i =0;i<data.Count;i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                    location = i;
                }
            }
            return location;
        }
    }
}