using aManga.Data;
using System.ComponentModel.DataAnnotations;

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


    }
}
