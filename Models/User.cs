using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace GazaChildSupport.Models
{
    [Table("user")]
    public class User : BaseModel
    {
        [PrimaryKey("id")]        
        public Guid Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }
      
        [Column("avatar_url")]
        public string AvatarUrl { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        

    }
}