using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using CSITDemo.Models;
using Microsoft.AspNetCore.Mvc;
using CSITDemo.Services;

namespace CSITDemo.Controllers
{
    public class StudentController : Controller
    {
        //controller high level module ani service low level module 
        //dependencies inversion anusar high level modeule should depend on abstraction rather than low level module
        //StudentService service = new StudentService(); its violates abstraction of depen inver

        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var model = _service.GetAllStudents();
            return View(model);
        }



        public IActionResult Add()
        {
            return View();
        }
    }

}
