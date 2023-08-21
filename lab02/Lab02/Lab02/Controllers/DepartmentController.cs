using Lab02.Models;
using Microsoft.AspNetCore.Mvc;
 
namespace Lab02.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<DepartmentModel> list = new List<DepartmentModel>();
            list.Add(new DepartmentModel("Phòng Giám Đốc"));
            list.Add(new DepartmentModel("Phòng Kế Hoạch"));
            list.Add(new DepartmentModel("Phòng Kế Toán"));
            list.Add(new DepartmentModel("Phòng Sản Xuất"));
            list.Add(new DepartmentModel("Phòng Kinh Doanh"));
            ViewBag.ListDepartment = list;
            return View();
        }
    }
}
