namespace Bai2.Models
{
    public class BookModel
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public int Price { get; set; }
        public String avatar { get; set; }
        public BookModel() { }

        public BookModel(string id, string title, int price, string avatar)
        {
            Id = id;
            Title = title;
            Price = price;
            this.avatar = avatar;
        }
    }
}
