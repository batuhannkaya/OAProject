using Microsoft.AspNetCore.Mvc;

namespace CalculateAPI.Controllers
{
    public class BaseController : Controller
    {
        Business business = new Business();

        [HttpGet, Route("/Gizem/{a}/{b}")]
        public JsonResult Sum(double a, double b)
        {
            double c = business.Sum(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Batuhan/{a}/{b}")]
        public JsonResult Multiple(double a, double b)
        {
            double c = business.Multiple(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Atakan/{a}/{b}")]
        public JsonResult Extraction(double a, double b)
        {
            double c = business.Extraction(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Mine/{a}/{b}")]
        public JsonResult BaseOperation(double a, double b)
        {
            double c = business.BaseOperation(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Merve/{a}/{b}")]
        public JsonResult Divide(double a, double b)
        {
            double c = business.Divide(a, b);
            return Json(c);
        }
    }
}
