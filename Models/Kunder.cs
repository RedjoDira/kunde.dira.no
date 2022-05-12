using System.ComponentModel.DataAnnotations;

namespace kunde.dira.no.Models
{
    public class Kunder
    {
        [Key]
        public long OrgNr { get; set; }
        public string Adresse { get; set; }
        public string PostNrSted { get; set; }
        public string KontaktPTek { get; set; }
        public string KontaktPØk { get; set; }
        public string KontaktPLed { get; set; }

        public string TripleTID { get; set; }



    }
}
