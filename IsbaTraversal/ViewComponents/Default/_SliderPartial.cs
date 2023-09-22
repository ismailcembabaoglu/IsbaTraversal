using Microsoft.AspNetCore.Mvc;

namespace IsbaTraversal.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
