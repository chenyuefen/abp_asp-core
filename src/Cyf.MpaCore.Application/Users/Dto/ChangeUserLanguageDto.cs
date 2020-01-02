using System.ComponentModel.DataAnnotations;

namespace Cyf.MpaCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}