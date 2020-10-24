using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        public String PropertyNo { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String Ptype { get; set; }
        public int Rooms { get; set; }
        public int rent { get; set; }

        [ForeignKey("Staff_tbl")]
        [Display(Name = "Staff No")]
        public string StaffNo_Ref { get; set; }
        public Staff Staff_tbl { get; set; }

        [ForeignKey("Branch_tbl")]
        [Display(Name = "Branch No")]
        public String BranchNo_Ref { get; set; }
        public Branch Branch_tbl { get; set; }

        [ForeignKey("Owner_tbl")]
        [Display(Name = "Owner No")]
        public String Owner_Ref { get; set; }
        public Owner Owner_tbl { get; set; }
    }
}