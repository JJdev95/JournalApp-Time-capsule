using Microsoft.AspNetCore.Mvc;

namespace TimeCapsule.API.Controllers
{
    public class FallBackController : ControllerBase
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
    }
}