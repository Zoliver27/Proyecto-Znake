using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Usuarios")]
    public class Usuario_Ent
    {
        [Key]
        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(30)]
        public string Rol { get; set; } = string.Empty;
    }
}