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
        private companycontext companycontext = new companycontext();
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
            rents.StaffNo_Ref = updatedRent.StaffNo_Ref;
            rents.BranchNo_Ref = updatedRent.BranchNo_Ref;
            rents.Owner_Ref = updatedRent.Owner_Ref;
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

        public ActionResult Get_City()
        {
            var AllCity = companycontext.Rents.ToList();

            int i = 0;
            int j = 0;

            foreach (Rent rents in AllCity)
            {
                i = i + 1;
            }

            string[] build = new string[i];
            foreach (Rent rents in AllCity)
            {
                build[j] = rents.City;
                j = j + 1;
            }

            var distinctArray = build.Distinct().ToArray();
            ViewBag.citydetails = distinctArray;
            return View();
        }

        public ActionResult Get_City1(string city_id)
        {
            List<Rent> rents = companycontext.Rents.Where(x => x.City == city_id).ToList();
            return View(rents);
        }
        public ActionResult NoofBuildings()
        {
            var Allbulilding = companycontext.Rents.ToList();

            int i = 0;
            int j = 0;

            foreach (Rent rents in Allbulilding)
            {
                i = i + 1;
            }

            string[] building = new string[i];
            foreach (Rent rents in Allbulilding)
            {
                building[j] = rents.BranchNo_Ref;
                j = j + 1;
            }

            var distinctArray = building.Distinct().ToArray();
            ViewBag.buildingsdetails = distinctArray;
            return View();
        }
        public ActionResult NoofBuildings1(string building_id)
        {
            var rents = companycontext.Rents.Where(x => x.BranchNo_Ref == building_id).ToList().Count();
            ViewBag.noofbuildings=rents;
            return View();
        }
    }

    
}