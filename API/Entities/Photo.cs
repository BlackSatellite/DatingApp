using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }

        // Navigation properties
        // (Required one to many relationship)
         public int AppUserId { get; set; }

        //The = null!; construct is used to mark this as intentional for the C# compiler,
        //since EF typically sets the AppUser instance 
        //and it cannot be null for a fully loaded relationship. 
        public AppUser AppUser { get; set; } = null!;
    }
}