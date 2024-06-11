using System.ComponentModel.DataAnnotations;

namespace showit.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }
        public int Age { get; set; }
        
        public string Password { get; set; }

        public bool isActive { get; set; }

   
    }
}
