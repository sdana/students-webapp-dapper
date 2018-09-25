using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Workforce.Models
{
    public class Cohort
    {
        public int Id { get; set; }

        [Display(Name = "Cohort")]
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    }

}