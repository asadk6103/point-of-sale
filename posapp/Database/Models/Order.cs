using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.Models
{
    public enum PaymentType
    {
        Cash,
        Card,
        EasyPaisa,
        JazzCash
    }

    [Table("orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment attribute
        [Column("id")]
        public int Id { get; set; }

        [Column("payment_type")]
        public PaymentType PaymentType { get; set; }

        [Column("txn_id")]
        public string TransactionId { get; set; }

        [Column("paid")]
        public float PaidAmount { get; set; }

        [Column("sub_total")]
        public float SubTotal { get; set; }

        [Column("returning_amount")]
        public float AmountReturned { get; set; }

        [Column("created_at")]
        public DateOnly createdAt { get; set; }

        [Column("updated_at")]
        public DateOnly updateddAt { get; set; }


        [ForeignKey("user_id")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
