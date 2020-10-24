using ICA_01_2015ICT36.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA_01_2015ICT36.Controllers
{
    public class BranchController : Controller
    {
        // GET: Branch
        private companycontext companycontext = new companycontext();
        public ActionResult Index()
        {
            List<Branch> AllBranches = companycontext.Branches.ToList();
            return View(AllBranches);
        }

        public ActionResult Create()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Create(Branch branch)
        {
           
            companycontext.Branches.Add(branch);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(String id)
        {
            Branch branch = companycontext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }
        public ActionResult Edit(String id)
        {
            Branch branch = companycontext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }
        [HttpPost]
        public ActionResult Edit(String id,Branch updatedBranch)
        {

            Branch branch = companycontext.Branches.SingleOrDefault(x => x.BranchNo == id);
            branch.BranchNo = updatedBranch.BranchNo;
            branch.City = updatedBranch.City;
            branch.Street = updatedBranch.Street;
            branch.PostCode = updatedBranch.PostCode;
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            Branch branch = companycontext.Branches.SingleOrDefault(x => x.BranchNo == id);
            return View(branch);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteBranch(String id)
        {

            Branch branch = companycontext.Branches.SingleOrDefault(x => x.BranchNo == id);
            companycontext.Branches.Remove(branch);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}