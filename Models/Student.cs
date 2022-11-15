using System.ComponentModel.DataAnnotations;
namespace HaVanDongBTH2.Models
{
    public class Student
    {
        [Key]
        public string StudentID {get; set;}
        
        public string StudentName {get; set;}
        public string StudentAge {get; set;}
    }
}