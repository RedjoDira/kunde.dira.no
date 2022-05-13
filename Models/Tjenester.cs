using System.ComponentModel.DataAnnotations;

namespace kunde.dira.no.Models
{
    public class Tjenester
    {
        [Key]
        public int TjenesterId { get; set; }
        public string TjenesterName { get; set; }
        public int TjenesterType { get; set; }
        
    }
}
