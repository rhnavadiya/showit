using Microsoft.AspNetCore.Mvc;
using showit.Models;
using System.Diagnostics;

namespace showit.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.data = "I am ViewBag data";//view bag data
            ViewData["data1"] = "I am ViewBag data";//view data
            ViewBag.Names = new List<string> { "Alice", "Bob", "Charlie" };
            TempData["name"] = "Bill";
            return View();
        }


        List<Student> studentlist = new List<Student>();

        public HomeController()
        {
            studentlist.Add(new Student() { StudentId = 1, StudentName = "Rutin", Age = 20, Password = "123", isActive = true});
            studentlist.Add(new Student() { StudentId = 2, StudentName = "Hareshbhai", Age = 21, Password = "456", isActive = false });
            studentlist.Add(new Student() { StudentId = 3, StudentName = "suresh", Age = 23, Password = "894", isActive = true });
        
        }//constructor

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student studnet = studentlist.FirstOrDefault(x => x.StudentId == id);

            return View(studnet);
        }//getting first student of data

        public ActionResult Grid()
        {
            return View(studentlist);
        }//get all data 



        [HttpPost]
        public ActionResult EditStudent()
        {
            var student = new Student();    
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
