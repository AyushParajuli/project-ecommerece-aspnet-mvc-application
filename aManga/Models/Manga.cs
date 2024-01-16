using aManga.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aManga.Models
{
    public class Manga
    {
        [Key]
        public int MangaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
        public double Price { get; set; }
        public string  ImageURL{ get; set; }
        public MangaCatagory MangaCatagory { get; set; }

        //Relationships
        public List<Character_Manga> character_Mangas { get; set; }

        //Studio
        public int F_StudioId { get; set; }
        [ForeignKey("F_StudioId")]
        public Studio Studio { get; set; }
        
        //Authors
        public int F_AuthorId { get; set; }
        [ForeignKey("F_AuthorId")]
        public Author Authors { get; set; }

    }
}
