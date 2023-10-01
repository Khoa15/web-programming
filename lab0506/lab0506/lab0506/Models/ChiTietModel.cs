namespace lab0506.Models
{
    public class ChiTietModel
    {

        public int Id { get; set; }
        public string ChiTiet { get; set; }
        public string FilePath { get; set; }
        public string Author { get; set; }
        public DateTime created { get; set; }

        public ChiTietModel(int id, string chiTiet, string filePath, string author, DateTime created)
        {
            Id = id;
            ChiTiet = chiTiet;
            FilePath = filePath;
            Author = author;
            this.created = created;
        }
        public ChiTietModel()
        {
            ChiTiet = String.Empty;
            FilePath = String.Empty;
            Author = String.Empty;
        }
    }
}
