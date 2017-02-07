using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BandMVC.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Release { get; set; }
        public int BandId { get; set; }

        public virtual Band Band { get; set; }
    }
}