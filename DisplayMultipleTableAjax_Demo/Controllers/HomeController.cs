using DisplayMultipleTableAjax_Demo.Models;
using System.Linq;
using System.Web.Mvc;

namespace DisplayMultipleTableAjax_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly SampleDBContext db = new SampleDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataTable()
        {
            return View();
        }

        public JsonResult GetCustomers()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var customers = db.Customers.ToList();
            return Json(new { data = customers }, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult GetProducts()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var orders = db.Products.ToList();
            return Json(new { data = orders }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOrders()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var orders = db.Orders.ToList();
            return Json(new { data = orders }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOrderItem()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var orders = db.OrderItems.ToList();
            return Json(new { data = orders }, JsonRequestBehavior.AllowGet);
        }
    }
}