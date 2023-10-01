namespace lab0506.Models
{
    public class TinTucModel
    {
        public int Id { get; set; }
        public ChiTietModel ChiTiet { get; set; }
        public DateTime created { get; set; }
        public string Author { get; set; }
        public TinTucModel()
        {
            Author = string.Empty;
            ChiTiet = new ChiTietModel();
        }

        public TinTucModel(int id, ChiTietModel chiTiet, DateTime created, string author)
        {
            Id = id;
            ChiTiet = chiTiet;
            this.created = created;
            Author = author;
        }
    }
}
