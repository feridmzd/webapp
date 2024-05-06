using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       
        public   IActionResult  Index()
        {
            return View();



        }


        public IActionResult Index1()
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Ferid"
            };
            Student studen2 = new Student()
            {
                Id = 2,
                Name = "Namiq"

            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Natiq"
            };


            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(studen2);
            students.Add(student3);

            return View(students);

        }
     






    }
}