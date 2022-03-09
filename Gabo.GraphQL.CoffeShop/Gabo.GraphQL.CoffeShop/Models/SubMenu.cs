using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gabo.GraphQL.CoffeShop.Models
{
    [Table("SubMenu")]
    public class SubMenu
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("ImageUrl")]
        public string ImageUrl { get; set; }
        [Column("Price")]
        public double Price { get; set; }
        [Column("MenuId")]
        public int MenuId { get; set; }
    }
}
