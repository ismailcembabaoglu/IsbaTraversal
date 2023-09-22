using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IsbaTraversal.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c=new Context();
            ViewBag.v1 = c.Destinations.ToList().Count();
            ViewBag.v2=c.Guides.ToList().Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
