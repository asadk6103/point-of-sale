using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posapp.Database.Models
{

    public enum Role
    {
        Admin,
        Seller,
    }
    
    public enum ActiveStatus
    {
        Active,
        InActive,
    }


    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment attribute
        [Column("id")]
        public int Id { get; set; }

        [Column("display_name")]
        public string DisplayName { get; set; }


        [Column("email")]
        public string Email { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("role")]
        public Role Role{ get; set; }

        [Column("status")]
        public ActiveStatus Status { get; set; }

        [Column("created_at")]
        public DateOnly createdAt { get; set; }

        [Column("updated_at")]
        public DateOnly updateddAt { get; set; }

        public virtual ICollection<Demands> Demands { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Products> Products { get; set; }



    }
}
