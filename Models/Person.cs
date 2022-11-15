using System.ComponentModel.DataAnnotations;
namespace HaVanDongBTH2.Models
{
    public class Person
    {
        [Key]
        public string PersonID {get; set;}
        
        public string PersonName {get; set;}
        public string PersonAge {get; set;}
    }
}