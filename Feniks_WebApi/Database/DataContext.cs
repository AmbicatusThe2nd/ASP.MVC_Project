using Microsoft.EntityFrameworkCore;
using Naloga2_Tkalcic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feniks_WebApi.Database
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Izposoja> Izposoje { get; set; }
    }
}
