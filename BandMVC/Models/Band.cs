using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BandMVC.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Formed { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }

    public class BandContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}