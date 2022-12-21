using System.ComponentModel.DataAnnotations;

namespace AppVol.Models
{
    public class vol
    {
        [Key]

     public int id { get; set; }

        [Required]

        public string villeDepart { get; set; }
        public string villeArrive { get; set; }


        public DateTime periodeDate { get; set; } 

        public string ClassEconomique { get; set; }







    }
}
