using ICA_01_2015ICT36.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA_01_2015ICT36.Controllers
{
    public class OwnerController : Controller
    {
        // GET: Owner
        private CompanyContext companycontext = new CompanyContext();
        public ActionResult Index()
        {
            List<Owner> AllOwners = companycontext.Owners.ToList();
            return View(AllOwners);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            companycontext.Owners.Add(owner);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(String id)
        {
            Owner owner = companycontext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }
        public ActionResult Edit(String id)
        {
            Owner owner = companycontext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }
        [HttpPost]
        public ActionResult Edit(String id,Owner updatedOwner)
        {
            Owner owner = companycontext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            owner.Fname = updatedOwner.Fname;
            owner.Lname = updatedOwner.Lname;
            owner.Address = updatedOwner.Address;
            owner.TelNo = updatedOwner.TelNo;
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            Owner owner = companycontext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            return View(owner);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteOwner(String id)
        {
            Owner owner = companycontext.Owners.SingleOrDefault(x => x.OwnerNo == id);
            companycontext.Owners.Remove(owner);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}