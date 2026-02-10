using japanese_character_practices.Components.Model;
using Microsoft.EntityFrameworkCore;

namespace japanese_character_practices.Components.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<JapaneseGojuuonCharacter> japaneseGojuuonCharacters { get; set; } = null!;
        public DbSet<JapaneseYouonCharacter> japaneseYouonCharacters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Japanese_charecter_practices");
        }
    }
}
