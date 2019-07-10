using JoiningTablesImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoiningTablesImplementation.Controllers
{
    public class ViewModelController : Controller
    {
        JoiningTablesImplementationContext db = new JoiningTablesImplementationContext();
        // GET: ViewModel
        public ActionResult Index(string search)
        {
            List<ViewModel> vm = new List<ViewModel>();
            var list = (from x in db.Courses
                        join a in db.Students on x.CourseId equals a.CourseId
                        select new { a.StdName, a.stdNum, x.CourseName, x.StartDate, x.EndDate });
            foreach (var item in list)
            {
                ViewModel vms = new ViewModel();
                vms.StdName = item.StdName;
                vms.stdNum = item.stdNum;
                vms.CourseName = item.CourseName;
                vms.StartDate = item.StartDate;
                vms.EndDate = item.EndDate;

                vm.Add(vms);
             
            }

            
            return View(vm.ToList());
        }

       
    }
}