using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai3.Models
{
    public class BookModel
    {
        [Key]
        public String Id { get;set; }
        public string Title { get;set; }
        public string Avatar { get; set; }
        public ProducerModel Producer { get; set; }
        public BookModel() {
            Id = String.Empty;
            Title = String.Empty;
            Avatar = String.Empty;
            Producer = new ProducerModel();
        }

        public BookModel(string id, string title, string avatar, ProducerModel producer)
        {
            Id = id;
            Title = title;
            Avatar = avatar;
            Producer = producer;
        }
    }
}
