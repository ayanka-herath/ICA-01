using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    public class Staff_tbl
    {
        [Key]
        public String StaffNo { get; set; }
        public String Lname { get; set; }
        public String Fname { get; set; }
        public String Possition { get; set; }
        public DateTime DOB { get; set; }
        public int Salary { get; set; }

        [ForeignKey("Branch_tbl")]
        public String Branchno_Ref { get; set; }
        public Branch_tbl Branch_tbl { get; set; }
        public List<Rent_tbl> Rents { get; set; }
    }
}