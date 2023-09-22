using Microsoft.AspNetCore.Mvc;

namespace IsbaTraversal.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
