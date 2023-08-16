using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class KhoaController : Controller
    {
        public IActionResult Index()
        {
            Models.KhoaModel CNTTmodel = new Models.KhoaModel();
            CNTTmodel.Message = "FIT_HUIT: STUDY, UNITY, CREATIVE";
            return View(CNTTmodel);
        }
    }
}
