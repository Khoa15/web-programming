using lab0506.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace lab0506.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration Configuration;


        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [HttpPost]
        public IActionResult DangKy(ThanhVienModel tv)
        {
            if(tv.Ten != String.Empty)
            {
                var strcn = Configuration["Database:ConnectionString"];
                SqlConnection cn = new SqlConnection(strcn);
                cn.Open();
                String strcmd = $"INSERT INTO tbl_ThanhVien(TenThanhVien, MatKhau, Email) VALUES (@Ten, @MatKhau, @Email)";
                
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = strcmd;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Ten", tv.Ten);
                cmd.Parameters.AddWithValue("@MatKhau", tv.MatKhau);
                cmd.Parameters.AddWithValue("@Email", tv.Email);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Response.WriteAsync("Done");
                }
                cn.Close();
            }
            ViewBag.count = GetCountTV();

            return View();
        }

        private int GetCountTV()
        {
            SqlConnection cn = new SqlConnection(Configuration["Database:ConnectionString"]);
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_ThanhVien", cn);
            int result = (int)cmd.ExecuteScalar();
            cn.Close();
            return result;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [HttpPost]
        public IActionResult ThemChuDe(ChuDeModel chude)
        {
            ViewData["status"] = null;
            if (chude.Name != String.Empty)
            {
                SqlConnection cn = new SqlConnection(Configuration["Database:ConnectionString"]);
                cn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM tbl_ChuDe Where TenChuDe = '{chude.Name}'", cn);
                int result = (int)cmd.ExecuteScalar();
                if (result == 0)
                {
                    cmd = new SqlCommand($"INSERT INTO tbl_ChuDe VALUES ('{chude.Name}')", cn);
                    cmd.ExecuteNonQuery();
                    ViewData["status"] = 1;
                }else ViewData["status"] = 0;
                cn.Close();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}