using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Duenos")]
    public class Dueno_Ent
    {
        [Key]
        [Column("Id_Dueno")]
        public int Id_Dueno { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Telefono { get; set; }

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }
    }
}