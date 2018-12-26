using System.ComponentModel.DataAnnotations;

namespace HTCMobile.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}