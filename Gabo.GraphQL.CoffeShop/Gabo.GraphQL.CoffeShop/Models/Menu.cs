using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gabo.GraphQL.CoffeShop.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("ImageUrl")]
        public string ImageUrl { get; set; }
        [NotMapped]
        public ICollection<SubMenu> SubMenus { get; set; } 
    }
}
