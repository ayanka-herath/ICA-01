using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    public class Owner_tbl
    {
        [Key]
        public String OwnerNo { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Address { get; set; }
        public String TelNo { get; set; }
        public List<Rent_tbl> Rents { get; set; }

    }
}