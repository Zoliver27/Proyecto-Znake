using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Compras")]
    public class Compra_Ent
    {
        [Key]
        [Column("Id_Compras")]
        public int Id_Compras { get; set; }

        [Column("Id_Proveedor")]
        public int Id_Proveedor { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; } = 0.00m;

        [ForeignKey("Id_Proveedor")]
        public virtual Proveedor_Ent? Proveedor { get; set; }

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }
    }
}