using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba.Entities
{
    public class User
    {
        [Key]
        [Column("user_id")]
        public int Id { get; set; }

        [Required]
        [Column("user_firstname", TypeName = "VARCHAR(100)")]
        public string FirstName { get; set; }        
        
        [Required]
        [Column("user_lastname", TypeName = "VARCHAR(100)")]
        public string LastName { get; set; }        
        
        [Required]
        [Column("user_email", TypeName = "VARCHAR(100)")]
        public string Email { get; set; }        
        
        [Required]
        [Column("user_password", TypeName = "VARCHAR(50)")]
        public string Password { get; set; }        
        
    }
}
