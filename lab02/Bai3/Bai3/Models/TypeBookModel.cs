using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Bai3.Models
{
    [PrimaryKey(nameof(BookId), nameof(TypeId))]
    public class TypeBookModel
    {
        public String BookId { get; set; }
        public String TypeId { get; set; }
        public TypeBookModel()
        {
            BookId = String.Empty;
            TypeId = String.Empty;
        }

    }
}
