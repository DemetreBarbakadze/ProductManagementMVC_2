using Microsoft.AspNetCore.Mvc;

namespace ProductManagementMVC_2.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
