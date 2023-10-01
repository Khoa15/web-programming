using System.ComponentModel.DataAnnotations;

namespace lab0506.Models
{
    public class ChuDeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
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
