using CIS174_MVC_Assignments.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CIS174_MVC_Assignments.Controllers
{
   
    public class AssignmentsController : Controller
    {
        [Route("Assignments/StudentLevel/{accessLevel:int}")]
        public ActionResult StudentLevel(int accessLevel)
        {
            var students = new List<Student>
        {
            new Student { FirstName = "Jane", LastName = "Johnson", Grade = "A" },
            new Student { FirstName = "Larry", LastName = "Brown", Grade = "B+" },
            new Student { FirstName = "Kelly", LastName = "Lee", Grade = "A-" },
            new Student { FirstName = "Jill", LastName = "Oman", Grade = "B" }
        };

            var viewModel = new StudentViewModel
            {
                AccessLevel = accessLevel,
                Students = students
            };

            return View(viewModel);
        }
    }
}
