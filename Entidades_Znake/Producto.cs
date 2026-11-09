using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Productos")]
    public class Producto_Ent
    {
        [Key]
        [Column("Id_Productos")]
        public int Id_Productos { get; set; }

        [Column("Id_Marca")]
        public int Id_Marca { get; set; }

        [Column("Id_Proveedor")]
        public int Id_Proveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Precio { get; set; } = 0.00m;

        public int Stock { get; set; } = 0;

        [StringLength(50)]
        public string? Categoria { get; set; }

        [ForeignKey("Id_Marca")]
        public virtual Marca_Ent? Marca { get; set; }

        [ForeignKey("Id_Proveedor")]
        public virtual Proveedor_Ent? Proveedor { get; set; }
    }
}