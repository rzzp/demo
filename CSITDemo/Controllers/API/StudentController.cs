using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSITDemo.Models;

namespace CSITDemo.Controllers.API
{
    [Route("api/[controller]")] //compulsary from .NET core
    [ApiController]
 
        public class StudentController : ControllerBase
        {
            public List<StudentModel> Get()
            {
                return GetStudentModelsFromDb();
            }
            private List<StudentModel> GetStudentModelsFromDb()
            {
                List<StudentModel> students = new List<StudentModel>();
                students.Add(new StudentModel { Name = "Aavash",Address = "satdobato" });
                students.Add(new StudentModel { Name = "Sabin", Address = "Bhaktapur" });
                students.Add(new StudentModel { Name = "Bibek", Address = "Jadibuti" });

                return students;
            }
        }
 
  
}
