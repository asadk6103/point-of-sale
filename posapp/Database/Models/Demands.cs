using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.Models
{
    [Table("demands")]
    public class Demands
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment attribute
        [Column("id")]
        public int Id { get; set; }

        [Column("item")]
        public string ItemName { get; set; }

        [Column("created_at")]
        public DateOnly createdAt { get; set; }

        [Column("updated_at")]
        public DateOnly updateddAt { get; set; }


        [ForeignKey("user_id")]
        public int UserId { get; set; }
        public virtual User User { get; set; }


    }
}
