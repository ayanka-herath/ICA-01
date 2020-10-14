using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    public class Branch_tbl
    {
        [Key]
        public String BranchNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String PostCode { get; set; }
        public List<Rent_tbl> Rents { get; set; }
        public List<Staff_tbl> Staff { get; set; }
    }
}