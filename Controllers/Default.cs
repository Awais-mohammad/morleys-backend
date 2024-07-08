using Microsoft.AspNetCore.Mvc;

namespace morleys_backend.Controllers
{
    [ApiController]          
    [Route("")]
    public class Default : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Default");
        }
    }
}
