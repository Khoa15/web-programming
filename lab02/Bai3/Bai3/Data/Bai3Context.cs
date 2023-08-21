using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bai3.Models;

namespace Bai3.Data
{
    public class Bai3Context : DbContext
    {
        public Bai3Context (DbContextOptions<Bai3Context> options)
            : base(options)
        {
        }

        public DbSet<Bai3.Models.BookModel> BookModel { get; set; } = default!;

        public DbSet<Bai3.Models.TypeModel> TypeModel { get; set; } = default!;

        public DbSet<Bai3.Models.ProducerModel> ProducerModel { get; set; } = default!;
    }
}
