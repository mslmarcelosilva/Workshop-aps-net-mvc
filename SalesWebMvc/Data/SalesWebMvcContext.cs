using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc.Models.Departamentos> Departamentos { get; set; }
        public DbSet<SalesWebMvc.Models.Vendedores> Vendedores { get; set; }
        public DbSet<RegistroDeVendas> RegistroDeVendas { get; set; }
    }
}
