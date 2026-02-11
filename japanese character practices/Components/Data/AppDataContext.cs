using japanese_character_practices.Components.Model;
using Microsoft.EntityFrameworkCore;

namespace japanese_character_practices.Components.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<SuteganaKatakana> SuteganaKatakana { get; set; } = null!;
        public DbSet<YouonKatakana> YouonKatakana { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Katagana builders

            modelBuilder.Entity<YouonKatakana>()
                .HasKey(y => y.Id);

            modelBuilder.Entity<YouonKatakana>()
                .HasOne(y => y.GojuuonKatakana)
                .WithMany()
                .HasForeignKey(y => y.UnicodeBase)
                .HasPrincipalKey(g => g.Unicode);

            modelBuilder.Entity<YouonKatakana>()
                .HasMany(y => y.SuteganaKatakanas)
                .WithMany();

            // Hiragana builders

            modelBuilder.Entity<YouonHiragana>()
                .HasKey(y => y.Id);

            modelBuilder.Entity<YouonHiragana>()
                .HasOne(y => y.GojuuonHiragana)
                .WithMany()
                .HasForeignKey(y => y.UnicodeBase)
                .HasPrincipalKey(g => g.Unicode);

            modelBuilder.Entity<YouonHiragana>()
                .HasMany(y => y.SuteganaHiraganas)
                .WithMany();
        }

    }
}
