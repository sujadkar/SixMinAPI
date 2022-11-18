using System.ComponentModel.DataAnnotations;

namespace SixMinAPI.Models{
    public class Command{
        [Key]
        public int id{get;set;}
        [Required]
        public string? HowTo{get;set;}
        [Required]
        [MaxLength(5)]
        public string? Platform{get;set;}
        [Required]
        public string? CommandLine{get;set;}
    }
}