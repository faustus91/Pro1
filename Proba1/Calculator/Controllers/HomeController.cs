using System.Web.Mvc;
using Proba1;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace Calculator.Controllers
{
    public class HomeController : Controller
   {
       public ActionResult Index()
       {
            ViewBag.Operation = new SelectListItem[]
           {
               new SelectListItem()
               {
                   Value = "multi", Text ="multi"
                },
                new SelectListItem()
                {
                   Value = "Add", Text ="Add"
               },
                new SelectListItem()
               {
                   Value = "minus", Text ="minus"
               },
                new SelectListItem()
                {
                   Value = "Div", Text ="Div"
               }
           };
           return View();
       }

       public ActionResult About()
        {
           ViewBag.Message = "Your application description page.";

           return View();
       }

       public ActionResult Contact()
      {
          ViewBag.Message = "Your contact page.";

           return View();
        }

        [HttpPost]
        public ActionResult Index(double firstValue, double secondValue, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstValue, secondValue);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multi", Text ="multi"
                },
                new SelectListItem()
                {
                    Value = "Add", Text ="Add"
                },
              new SelectListItem()
                {
                    Value = "minus", Text ="minus"
                },
                new SelectListItem()
                {
                    Value = "Div", Text ="Div"
                }
            };
            return View();
        }
    }
} 