using System.ComponentModel.DataAnnotations;

namespace japanese_character_practices.Components.Model
{
    public class JapaneseYouonCharacter
    {
        [Key]
        public string Unicode { get; set; } = null!;
        public string JapaneseBase { get; set; } = null!;
        public string JapaneseAddon { get; set; } = null!;
        public string Roman { get; set; } = null!;
        public bool isNative { get; set; }
        public bool isDakuten { get; set; }
    }
}
