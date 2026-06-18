namespace PensionManagement.API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime JoiningDate { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
