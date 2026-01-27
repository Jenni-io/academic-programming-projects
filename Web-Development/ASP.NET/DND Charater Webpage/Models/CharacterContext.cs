using Microsoft.EntityFrameworkCore;

namespace Ch4Lab2.Models {
    public class CharacterContext : DbContext {
        // Constructor method
        public CharacterContext(DbContextOptions<CharacterContext> options)
            : base(options) { }

        public CharacterContext() { }

        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Ancestry> Ancestors { get; set; } 
        public DbSet<Class> Classes { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Class>().HasData(
                // adds recods to Class
                 new Class {
                     ClassId = 1,
                     Name = "Bard"
                 },
                 new Class {
                     ClassId = 2,
                     Name = "Cleric"
                 },
                 new Class {
                     ClassId = 3,
                     Name = "Druid"
                 },
                 new Class {
                     ClassId = 4,
                     Name = "Fighter"
                 },
                 new Class {
                     ClassId = 5,
                     Name = "Paladin"
                 },
                 new Class {
                     ClassId = 6,
                     Name = "Sorcerer"
                 }
                );
        
            // adds records to Ancestry
            modelBuilder.Entity<Ancestry>().HasData(
                new Ancestry {
                    AncestryId = 1,
                    Origin = "Elf"
                },
                new Ancestry {
                    AncestryId = 2,
                    Origin = "Dwarf"
                },
                 new Ancestry {
                     AncestryId = 3,
                     Origin = "Halfling"
                 },
                 new Ancestry {
                     AncestryId = 4,
                     Origin = "Gnome"
                 },
                 new Ancestry {
                     AncestryId = 5,
                     Origin = "Human"
                 },
                 new Ancestry {
                     AncestryId = 6,
                     Origin = "Half-elf"
                 }
                );
            // Adds records to Chracter 
            modelBuilder.Entity<Character>().HasData(
                new Character {
                    CharacterID = 1,
                    FirstName = "Markimus",
                    LastName = "Maximus",
                    ClassId = 5,
                    AncestryId = 6,
                    Strength = 16,
                    Intelligence = 11
                },
                new Character {
                    CharacterID = 2,
                    FirstName = "Loismus",
                    LastName = "Blaismus",
                    ClassId = 2,
                    AncestryId = 2,
                    Strength = 10,
                    Intelligence = 18
                }
            );
        } // end method
    
    } // end class
} // end namespace