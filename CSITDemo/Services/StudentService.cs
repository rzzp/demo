using CSITDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSITDemo.Services
{
    public class StudentService : IStudentService
    {


        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { Name = "Aavash", Address = "satdobato" });
            students.Add(new StudentModel { Name = "Sabin", Address = "Bhaktapur" });
            students.Add(new StudentModel { Name = "Bibke", Address = "Jadibuti" });

            return students;
        }
    }
}