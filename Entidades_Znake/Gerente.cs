using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Gerentes")]
    public class Gerente_Ent
    {
        [Key]
        [Column("Id_Gerente")]
        public int Id_Gerente { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Column("Id_Admin")]
        public int Id_Admin { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(50)]
        public string? Area { get; set; }

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }

        [ForeignKey("Id_Admin")]
        public virtual Admin_Ent? Administrador { get; set; }
    }
}