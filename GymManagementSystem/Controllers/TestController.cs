using Microsoft.AspNetCore.Mvc;

namespace GymManagementSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            object Data = 10;
            return View(Data);
        }

        public IActionResult Hamada(int id)
        {
            return View(id);
        }
    }
}
