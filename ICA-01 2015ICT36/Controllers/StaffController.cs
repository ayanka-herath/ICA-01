using ICA_01_2015ICT36.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA_01_2015ICT36.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        private companycontext companycontext = new companycontext();
        public ActionResult Index()
        {
            List<Staff> AllStaff = companycontext.Staffs.ToList();
            return View(AllStaff);
        }

        public ActionResult Create()
        {
            ViewBag.BranchDetails = companycontext.Branches;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            ViewBag.BranchDetails = companycontext.Branches;
            companycontext.Staffs.Add(staff);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            Staff staff = companycontext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }
        public ActionResult Edit(String id)
        {
            Staff staff = companycontext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            ViewBag.BranchDetails = companycontext.Branches;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(String id, Staff updatedStaff)
        {
           
            Staff staff = companycontext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            
            staff.Fname = updatedStaff.Fname;
            staff.Lname = updatedStaff.Lname;
            staff.Possition = updatedStaff.Possition;
            staff.DOB = updatedStaff.DOB;
            staff.Salary = updatedStaff.Salary;
            staff.Branchno_Ref = updatedStaff.Branchno_Ref;
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            Staff staff = companycontext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            return View(staff);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteStaff(String id)
        {

            Staff staff = companycontext.Staffs.SingleOrDefault(x => x.StaffNo == id);
            companycontext.Staffs.Remove(staff);
            companycontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Get_Staff()
        {
            var Allstaff = companycontext.Staffs.ToList();

            int i = 0;
            int j = 0;

            foreach (Staff staff in Allstaff)
            {
                i = i + 1;
            }

            string[] possition = new string[i];
            foreach (Staff staff in Allstaff)
            {
                possition[j] = staff.Possition;
                j = j + 1;
            }

            var distinctArray = possition.Distinct().ToArray();
            ViewBag.possitiondetails = distinctArray;
            return View();
        }

        public ActionResult Get_Staff1(string possiton_det)
        {
            List<Staff> staff = companycontext.Staffs.Where(x => x.Possition == possiton_det).ToList();
            return View(staff);
        }
    }
}
