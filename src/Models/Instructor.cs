using Dapper;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;


namespace Workforce.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]           
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }

        public string Specialty { get; set; }

        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }

        [Display(Name = "Instructor Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
