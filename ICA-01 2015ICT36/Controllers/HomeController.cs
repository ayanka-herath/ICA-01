using ICA_01_2015ICT36.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA_01_2015ICT36.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private companycontext companycontext = new companycontext();
        public ActionResult Index()
        {
            List<Branch> AllBranches = companycontext.Branches.ToList();
            return View(AllBranches);
        }
        public ActionResult Staff_details()
        {
            List<Staff> AllStaff = companycontext.Staffs.ToList();
            return View(AllStaff);
        }

        public ActionResult Owner_details()
        {
            List<Owner> AllOwners = companycontext.Owners.ToList();
            return View(AllOwners);
        }
        public ActionResult Rent_details()
        {
            List<Rent> Allrents = companycontext.Rents.ToList();
            return View(Allrents);
        }
    }
}