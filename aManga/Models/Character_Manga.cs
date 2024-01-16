namespace aManga.Models
{
    //Joint class
    public class Character_Manga
    {
        public int F_MangaId { get; set; } // this is the foregin key for the movie model.
        
        public Manga Manga { get; set; }
        public int F_Characterid { get; set; }
        public characters Character { get; set; }
    }
}
