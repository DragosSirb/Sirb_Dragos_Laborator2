using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sirb_Dragos_Laborator2.Models;

namespace Sirb_Dragos_Laborator2.Data
{
    public class Sirb_Dragos_Laborator2Context : DbContext
    {
        public Sirb_Dragos_Laborator2Context (DbContextOptions<Sirb_Dragos_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Sirb_Dragos_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sirb_Dragos_Laborator2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
