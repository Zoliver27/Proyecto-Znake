using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Detalle_Carrito")]
    public class DetalleCarrito_Ent
    {
        [Key]
        [Column("Id_Detalle_Carrito")]
        public int Id_Detalle_Carrito { get; set; }

        [Column("Id_Carrito")]
        public int Id_Carrito { get; set; }

        [Column("Id_Producto")]
        public int Id_Producto { get; set; }

        public int Cantidad { get; set; } = 1;

        [ForeignKey("Id_Carrito")]
        public virtual Carrito_Ent? Carrito { get; set; }

        [ForeignKey("Id_Producto")]
        public virtual Producto_Ent? Producto { get; set; }
    }
}