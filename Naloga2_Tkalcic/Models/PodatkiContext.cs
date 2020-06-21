using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Naloga2_Tkalcic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Controllers
{
    public class PodatkiContext : IdentityDbContext<Uporabnik>
    {
        public PodatkiContext()
        {

        }
        public PodatkiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Uporabnik> Uporabniki { get; set; }
        public DbSet<Film> Filmi { get; set; }
        public DbSet<Izposoja> Izpsoje { get; set; }
        /*
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PodatkiPodatkov;Integrated Security=True");

        }*/
       
    }
}
