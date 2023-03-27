using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NguyenngocthanhThanh_2080600664_20DTHD3.Models;
using NguyenngocthanhThanh_2080600664_20DTHD3.ViewModels;

namespace NguyenngocthanhThanh_2080600664_20DTHD3.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();

        }

        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
            .Include(c => c.Lecturer)
            .Include(c => c.Category)
            .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CoursesViewModel 
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
      
            return View(viewModel);
        }
    }
}