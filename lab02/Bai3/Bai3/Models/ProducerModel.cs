using System.Net.Http.Headers;

namespace Bai3.Models
{
    public class ProducerModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ProducerModel
            ()
        {
            Id = String.Empty;
            Name = String.Empty;
        }

        public ProducerModel(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
