using ICA_01_2015ICT36.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA_01_2015ICT36.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent
        private CompanyContext companycontext = new CompanyContext();
        public ActionResult Index()
        {
            List<Rent> Allrents = companycontext.Rents.ToList();
            return View(Allrents);
        }
        public ActionResult Create()
        {
            ViewBag.BranchDetails = companycontext.Branches;
            ViewBag.OwnerDetails = companycontext.Owners;
            ViewBag.StaffDetails = companycontext.Staffs;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Rent rents)
        {
            ViewBag.BranchDetails = companycontext.Branches;
            ViewBag.OwnerDetails = companycontext.Owners;
            ViewBag.StaffDetails = companycontext.Staffs;
            companycontext.Rents.Add(rents);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            Rent rents = companycontext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rents);
        }
        public ActionResult Edit(String id)
        {
            Rent rents = companycontext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            ViewBag.BranchDetails = companycontext.Branches;
            ViewBag.OwnerDetails = companycontext.Owners;
            ViewBag.StaffDetails = companycontext.Staffs;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(String id, Rent updatedRent)
        {

            Rent rents = companycontext.Rents.SingleOrDefault(x => x.PropertyNo == id);

            rents.City = updatedRent.City;
            rents.Street = updatedRent.Street;
            rents.Ptype = updatedRent.Ptype;
            rents.Rooms = updatedRent.Rooms;
            rents.rent = updatedRent.rent;
            rents.BranchNo_Ref = updatedRent.BranchNo_Ref;
            rents.Owner_Ref = updatedRent.Owner_Ref;
            rents.StaffNo_Ref = updatedRent.StaffNo_Ref;
            companycontext.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(String id)
        {
            Rent rents = companycontext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            return View(rents);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteRent(String id)
        {
            Rent rents = companycontext.Rents.SingleOrDefault(x => x.PropertyNo == id);
            companycontext.Rents.Remove(rents);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}