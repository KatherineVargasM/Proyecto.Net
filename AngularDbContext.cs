using Api_Angular.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Api_Angular
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions op) : base(op)
        {

        }
        public DbSet<paisModel> Paises { get; set; }
        public DbSet<provinciaModel> Provincias { get; set; }
        public DbSet<cantonModel> Cantones { get; set; }
        public DbSet<direccionModel> Direcciones { get; set; }


    }
}