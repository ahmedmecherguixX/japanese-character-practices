using System.ComponentModel.DataAnnotations;

namespace japanese_character_practices.Components.Model
{
    public class YouonKatakana
    {
        public int Id { get; set; }
        public string UnicodeBase { get; set; } = null!;
        public ICollection<SuteganaKatakana> SuteganaKatakanas { get; set; } = new List<SuteganaKatakana>();
        public string Roman { get; set; } = null!;

        public GojuuonKatakana GojuuonKatakana { get; set; } = null!;
    }
}
