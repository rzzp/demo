using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSITDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSITDemo.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            var model = GetTeacherModelsDb();
            return View(model);
        }
        private List<TeacherModel> GetTeacherModelsDb()
        {
            List<TeacherModel> teachers = new List<TeacherModel>();
            teachers.Add(new TeacherModel{ Name = "Raju ",Subject = "Math"});
            teachers.Add(new TeacherModel{ Name = "Shyam ", Subject = "Science" });
            teachers.Add(new TeacherModel{ Name = "BabuRao ", Subject = "Social" });
            return teachers;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

    }
}
