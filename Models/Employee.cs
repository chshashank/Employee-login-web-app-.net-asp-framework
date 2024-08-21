using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(5)]
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobRole { get; set; }
        public string ReportingManager { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string TotalITExperience { get; set; }
        public string BachelorDegree { get; set; }
        public string BachelorSpecialization { get; set; }
        public string MastersDegree { get; set; }
        public string MastersSpecialization { get; set; }
        public string Certifications { get; set; }
    }
}
