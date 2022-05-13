using System.ComponentModel.DataAnnotations;

namespace kunde.dira.no.Models
{
    public class Kontakter
    {
        [Key]
        public long OrgNr { get; set; }
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }

        public string Epost { get; set; }
        public string Adresse { get; set; }
        public string TlfNum { get; set; }

    }
}
