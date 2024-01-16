using aManga.Models;
using Microsoft.EntityFrameworkCore; // the base package for working with the entity framework core.

namespace aManga.Data
{
    public class AppDbContext:DbContext //inheriting from baseclass Dbcontext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        //necessary for generating default authenticator
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character_Manga>().HasKey(am => new
            {
                am.F_Characterid,
                am.F_MangaId
            });

            //defining movie model in the c# side
            modelBuilder.Entity<Character_Manga>().HasOne(m => m.Manga).WithMany
                (am => am.character_Mangas).HasForeignKey(m => m.F_MangaId);
            
            //definin actor model in the C# side
            modelBuilder.Entity<Character_Manga>().HasOne(m => m.Character).WithMany
                (am => am.character_Mangas).HasForeignKey(m => m.F_Characterid);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<characters> Characters { get; set; }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Character_Manga> character_Mangas { get; set; }


    }
}
