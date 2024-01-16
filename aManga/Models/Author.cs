using System.ComponentModel.DataAnnotations;

namespace aManga.Models
{
    public class Author
    {
        [Key]
        public int Authorid { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
