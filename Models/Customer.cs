using System.ComponentModel.DataAnnotations;
namespace HaVanDongBTH2.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID {get; set;}
        
        public string CustomerName {get; set;}
        public string CustomerAge {get; set;}
    }
}