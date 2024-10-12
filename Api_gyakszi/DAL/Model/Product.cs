using System.ComponentModel.DataAnnotations;

namespace Api_gyakszi.DAL.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Megnevezes{ get; set; } = string.Empty;
        [Required]
        [MaxLength(25)]
        public string Kategoria { get; set; } = string.Empty;

        [Required]
        [Range (0,100000, ErrorMessage = "Az árnak {1} és {2} között kell lennie.")]
        public  int Ar { get; set; }

        public string Leiras { get; set; }= string.Empty;



    }
}
