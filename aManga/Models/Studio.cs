using System.ComponentModel.DataAnnotations;

namespace aManga.Models
{
    public class Studio
    {
        [Key]
        public int StudioiId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //RelationShips between manga and the studio which is many to one
        public List<Manga> Mangas { get; set; }
    }
}
