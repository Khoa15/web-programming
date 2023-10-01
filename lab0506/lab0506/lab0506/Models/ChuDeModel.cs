namespace lab0506.Models
{
    public class ChuDeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ChuDeModel()
        {
            Name = string.Empty;
        }

        public ChuDeModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
