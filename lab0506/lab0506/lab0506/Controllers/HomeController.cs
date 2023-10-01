using lab0506.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace lab0506.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
                String strcn = "Data Source=MUN\\SQLEXPRESS;Initial Catalog=QL_DTDD1;Integrated Security=True";
                SqlConnection cn = new SqlConnection(strcn);
                cn.Open();
                String strcmd = $"INSERT INTO tbl_ThanhVien(TenThanhVien, MatKhau, Email) VALUES (@Ten, @MatKhau, @Email)";
                
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = strcmd;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 50, tv.Ten);
                cmd.Parameters.Add("@MatKhau", System.Data.SqlDbType.NVarChar, 50, tv.MatKhau);
                cmd.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 50, tv.Email);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    Response.WriteAsync("Done");
                }
                cn.Close();
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}