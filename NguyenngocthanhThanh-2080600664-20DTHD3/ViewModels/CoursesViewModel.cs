using NguyenngocthanhThanh_2080600664_20DTHD3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenngocthanhThanh_2080600664_20DTHD3.ViewModels
{
    public class CoursesViewModel
    {
       public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}