using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Historial_Actividades")]
    public class HistorialAct_Ent
    {
        [Key]
        [Column("Id_Historial")]
        public int Id_Historial { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Accion { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }
    }
}