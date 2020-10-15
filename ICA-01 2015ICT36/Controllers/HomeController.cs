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
        private CompanyContext companycontext = new CompanyContext();
        public ActionResult Index()
        {
            List<Branch_tbl> AllBranches = companycontext.Branch.ToList();
            return View();
        }
    }
}