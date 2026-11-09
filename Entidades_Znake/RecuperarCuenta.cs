using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Recuperar_Cuenta")]
    public class RecuperarCuenta_Ent
    {
        [Key]
        [Column("Id_Recuperacion")]
        public int Id_Recuperacion { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Required]
        [StringLength(255)]
        [Column("Codigo_HASH")]
        public string Codigo_HASH { get; set; } = string.Empty;

        [Column("Fecha_Creacion")]
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;

        [Column("Fecha_Expiracion")]
        public DateTime Fecha_Expiracion { get; set; }

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }
    }
}