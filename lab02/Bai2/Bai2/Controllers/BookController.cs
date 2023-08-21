using Bai2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            List<BookModel> books = new List<BookModel>();
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            books.Add(new BookModel() { Id = "B01", Title = "Lẽ nào em không biết", avatar = "/imgs/b01.jpg", Price = 64200 });
            ViewBag.books = books;
            return View();
        }



    }
}
