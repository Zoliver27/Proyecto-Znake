using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Marcas")]
    public class Marca_Ent
    {
        [Key]
        [Column("Id_Marca")]
        public int Id_Marca { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
    }
}