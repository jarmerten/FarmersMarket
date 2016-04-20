using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Farmers_Market.Models
{
    public class ProduceContext : DbContext
    {
        public ProduceContext() : base("TheFarmStand")
      {
        }
        public DbSet<ProduceCategory> Categories { get; set; }
        public DbSet<Produce> Produces { get; set; }
    }
}