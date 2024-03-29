﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace aManga.Models
{
    public class characters
    {
        [Key]
        public int Characterid { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        
        //Relationship between character_manga and character many to one
        public List<Character_Manga> character_Mangas { get; set; }       
    }
}
