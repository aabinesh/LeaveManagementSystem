using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            var data = new TestViewModel {
                Name = "Student",
                DateOfBirth = new DateTime(2000, 01, 01)
            };
            return View(data);
        }

    }
}
