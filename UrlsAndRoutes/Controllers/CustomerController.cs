using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{
    [Route("app/[controller]/actions/[action]/{id:weekday?}")]
    public class CustomerController : Controller
    {
        //[Route("myroute")]
        public ViewResult Index() => View("Result",
            new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });

        //[Route("[controller]/MyAction")]
        public ViewResult List(string id)
        {
            Result r = new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(List),
            };
            r.Data["Id"] = id ?? "<no value>";
            r.Data["catchall"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    }
}
