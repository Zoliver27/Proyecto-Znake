using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Znake
{
    [Table("Vendedores")]
    public class Vendedor_Ent
    {
        [Key]
        [Column("Id_Vendedor")]
        public int Id_Vendedor { get; set; }

        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Column("Id_Gerente")]
        public int Id_Gerente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Telefono { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Comision { get; set; } = 0.00m;

        [ForeignKey("Id_Usuario")]
        public virtual Usuario_Ent? Usuario { get; set; }

        [ForeignKey("Id_Gerente")]
        public virtual Gerente_Ent? Gerente { get; set; }
    }
}