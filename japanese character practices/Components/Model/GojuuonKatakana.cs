using System.ComponentModel.DataAnnotations;

namespace japanese_character_practices.Components.Model
{
    public class GojuuonKatakana
    {
        [Key]
        public string Unicode { get; set; } = null!;
        public string Japanese { get; set; } = null!;
        public string Roman { get; set; } = null!;
        public bool IsDakuten { get; set; }
    }
}
