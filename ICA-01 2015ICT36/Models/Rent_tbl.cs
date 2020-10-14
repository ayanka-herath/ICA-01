using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    public class Rent_tbl
    {
        [Key]
        public String PropertyNo { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String Ptype { get; set; }
        public int Rooms { get; set; }
        public int rent { get; set; }

        [ForeignKey("Staff_tbl")]
        public String StaffNo_Ref { get; set; }
        public Staff_tbl Staff_tbl { get; set; }

        [ForeignKey("Branch_tbl")]
        public String BranchNo_Ref { get; set; }
        public Branch_tbl Branch_tbl { get; set; }

        [ForeignKey("Owner_tbl")]
        public String Owner_Ref { get; set; }
        public Owner_tbl Owner_tbl { get; set; }
    }
}