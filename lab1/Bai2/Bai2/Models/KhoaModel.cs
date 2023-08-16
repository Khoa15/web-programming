namespace Bai2.Models
{
    public class KhoaModel
    {
        public String TenKhoa { get; set; }
        public int NamThanhLap { get; set; }
        public String Message { get; set; }
        public KhoaModel()
        {
            TenKhoa = "Khoa Cong Nghe Thong Tin";
            NamThanhLap = 2003;
            Message = "Welcome to FIT_HUIT";
        }
    }
}
