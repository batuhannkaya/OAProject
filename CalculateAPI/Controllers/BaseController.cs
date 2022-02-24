using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CalculateAPI.Controllers
{
    public class BaseController : Controller
    {
        Business business = new Business();

        [HttpGet, Route("/Gizem/{a}/{b}")]
        public JsonResult Çarpma(double a, double b)
        {
            double c = business.Sum(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Batuhan/{a}/{b}")]
        public JsonResult Toplama(double a, double b)
        {
            double c = business.Multiple(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Atakan/{a}/{b}")]
        public JsonResult Çıkarma(double a, double b)
        {
            double c = business.Extraction(a, b);
            return Json(c);
        }

        [HttpGet, Route("/Mine/{a}/{b}")]
        public JsonResult ÜssüAlma(double a, double b)
        {
            double c = business.BaseOperation(a, b);
            return Json(c);
        }

        [HttpGet,Route("/Merve/{a}/{b}")]
        public JsonResult Bölme(double a, double b)
        {
            double c = business.Divide(a, b);
            return Json(c);
        }
        






    }
}
