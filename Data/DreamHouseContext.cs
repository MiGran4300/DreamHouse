#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DreamHouse.Models;

namespace DreamHouse.Data
{
    public class DreamHouseContext : DbContext
    {
        public DreamHouseContext (DbContextOptions<DreamHouseContext> options)
            : base(options)
        {
        }

        public DbSet<DreamHouse.Models.Building> Building { get; set; }
        public DbSet<DreamHouse.Models.Offer> Offer { get; set; }
    }
}
