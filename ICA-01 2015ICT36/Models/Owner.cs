using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA_01_2015ICT36.Models
{
    [Table("Owner_tbl")]
    public class Owner
    {
        
        [Key]
        public String OwnerNo { get; set; }
        [Display(Name = "First Name")]
        public String Fname { get; set; }
        [Display(Name = "Last Name")]
        public String Lname { get; set; }
        [DataType(DataType.MultilineText)]
        public String Address { get; set; }
        public String TelNo { get; set; }
        public List<Rent> Rents { get; set; }

    }
}