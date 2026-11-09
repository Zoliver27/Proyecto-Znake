using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Detalle_Compra")]
    public class DetalleCompra_Ent
    {
        [Key]
        [Column("Id_Detalle")]
        public int Id_Detalle { get; set; }

        [Column("Id_Compras")]
        public int Id_Compras { get; set; }

        [Column("Id_Productos")]
        public int Id_Productos { get; set; }

        public int Cantidad { get; set; } = 1;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Precio { get; set; }

        [ForeignKey("Id_Compras")]
        public virtual Compra_Ent? Compra { get; set; }

        [ForeignKey("Id_Productos")]
        public virtual Producto_Ent? Producto { get; set; }
    }
}