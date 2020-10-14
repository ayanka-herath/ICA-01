using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Branch_tbl> Branch { get; set; }
        public DbSet<Staff_tbl> Staff { get; set; }
        public DbSet<Rent_tbl> Rents { get; set; }
        public DbSet<Owner_tbl> Owner { get; set; }

    }
}