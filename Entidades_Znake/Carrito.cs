using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Carrito")]
    public class Carrito_Ent
    {
        [Key]
        [Column("Id_Carrito")]
        public int Id_Carrito { get; set; }

        [Column("Id_Cliente")]
        public int Id_Cliente { get; set; }

        [Column("Fecha_Creacion")]
        public DateTime Fecha_Creacion { get; set; } = DateTime.Now;

        [ForeignKey("Id_Cliente")]
        public virtual Cliente_Ent? Cliente { get; set; }
    }
}