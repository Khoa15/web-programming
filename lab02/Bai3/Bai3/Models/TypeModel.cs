namespace Bai3.Models
{
    public class TypeModel
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public List<TypeBookModel> TypeBooks { get; set; }
        public TypeModel()
        {
            Id = String.Empty;
            Name = String.Empty;
            TypeBooks = new List<TypeBookModel>();
        }
        public TypeModel(String id, String name, List<TypeBookModel> typeBooks)
        {
            Id = id;
            Name = name;
            TypeBooks = typeBooks;
        }
    }
}
