using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Ventas")]
    public class Venta_Ent
    {
        [Key]
        [Column("Id_Ventas")]
        public int Id_Ventas { get; set; }

        [Column("Id_Producto")]
        public int Id_Producto { get; set; }

        [Column("Id_Cliente")]
        public int Id_Cliente { get; set; }

        [Column("Id_Vendedor")]
        public int Id_Vendedor { get; set; }

        public int Cantidad { get; set; } = 1;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [ForeignKey("Id_Producto")]
        public virtual Producto_Ent? Producto { get; set; }

        [ForeignKey("Id_Cliente")]
        public virtual Cliente_Ent? Cliente { get; set; }

        [ForeignKey("Id_Vendedor")]
        public virtual Vendedor_Ent? Vendedor { get; set; }
    }
}