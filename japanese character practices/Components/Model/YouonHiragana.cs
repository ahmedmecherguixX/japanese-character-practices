namespace japanese_character_practices.Components.Model
{
    public class YouonHiragana
    {
        public int Id { get; set; }
        public string UnicodeBase { get; set; } = null!;
        public ICollection<SuteganaHiragana> SuteganaHiraganas { get; set; } = new List<SuteganaHiragana>();
        public string Roman { get; set; } = null!;

        public GojuuonHiragana GojuuonHiragana { get; set; } = null!;
    }
}
