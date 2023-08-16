using Microsoft.AspNetCore.Mvc;
using Bai3_DangNhap.Models;
using System.Text.Json;

namespace Bai3_DangNhap.Controllers
{
    public class UserController : Controller
    {

        public IActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DangNhap(string name, string password)
        {
            if("yennh".Equals(name) && "123456".Equals(password))
            {
                User user = new User() { Email = "yennh@gmail.com", Fullname = "Nguyễn Hải Yến", Password = password, PhoneNumber = "0923432043", UserName = name };
                HttpContext.Session.SetString("user", JsonSerializer.Serialize(user));
                
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult DangKy()
        {
            return View();
        }

        public IActionResult DangXuat()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
