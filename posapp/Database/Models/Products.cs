using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.Models
{

    public enum Status {
        OutOfStock,
        Expired,
        LowStock,
    }

    [Table("products")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment attribute
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string ProductName { get; set; }

        [Column("sale_price")]
        public float SalePrice { get; set; }

        [Column("purchase_price")]
        public float PurchasePrice { get; set; }

        [Column("quantity")]
        public int QuantityStock { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("status")]
        public Status Status { get; set; }

        [Column("created_at")]
        public DateOnly createdAt { get; set; }

        [Column("updated_at")]
        public DateOnly updateddAt { get; set; }


        [ForeignKey("user_id")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
