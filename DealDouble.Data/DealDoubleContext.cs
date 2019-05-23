using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealDouble.Entities;

namespace DealDouble.Data
{
    public class DealDoubleContext : DbContext
    {
        public DealDoubleContext() : base("name=DealDoubleConnectionString")
        {
        }

        //public DealDoubleContext() : base("DealDoubleConnectionString")
        //{

        //}

        public DbSet<Auction> MyProperty { get; set; }
    }
}
