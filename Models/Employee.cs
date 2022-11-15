using System.ComponentModel.DataAnnotations;
namespace HaVanDongBTH2.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID {get; set;}
        
        public string EmployeeName {get; set;}
        public string EmployeeAge {get; set;}
    }
}