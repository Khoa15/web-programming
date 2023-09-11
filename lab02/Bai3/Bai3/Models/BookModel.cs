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
        public int Price { get; set; }
        public int IdType { get; set; }
        public int IdProducer { get; set; }
        public ProducerModel Producer { get; set; }
        public BookModel() {
            Id = String.Empty;
            Title = String.Empty;
            Avatar = String.Empty;
            Price = 0;
            IdType = 0;
            IdProducer = 0;
            Producer = new ProducerModel();
        }

        public BookModel(string id, string title, string avatar, int price, int idType, int idProducer, ProducerModel producer)
        {
            Id = id;
            Title = title;
            Avatar = avatar;
            Price = price;
            IdType = idType;
            IdProducer = idProducer;
            Producer = producer;
        }
    }
}
