using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.Models
{
    [Table("order_details")]
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment attribute
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateOnly createdAt { get; set; }

        [Column("updated_at")]
        public DateOnly updateddAt { get; set; }

        [ForeignKey("order_id")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
