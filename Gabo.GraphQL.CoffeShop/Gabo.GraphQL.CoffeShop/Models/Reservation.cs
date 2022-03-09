using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gabo.GraphQL.CoffeShop.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Phone")]
        public string Phone { get; set; }
        [Column("TotalPeople")]
        public int TotalPeople { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Date")]
        public DateTime Date { get; set; }
        [Column("Time")]
        public string Time { get; set; }

    }
}
