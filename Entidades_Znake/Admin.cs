using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Administradores")]
    public class Admin_Ent
    {
        [Key]
        [Column("Id_Admin")]
        public int Id_Admin { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Column("Id_Dueno")]
        public int Id_Dueno { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Telefono { get; set; }

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }

        [ForeignKey("Id_Dueno")]
        public virtual Dueno_Ent? Dueno { get; set; }
    }
}