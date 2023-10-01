using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai5.Models
{
    public class CountryModel
    {
        public string Name { get; set; }
        public CountryModel(string name)
        {
            Name = name;
        }
    }
}