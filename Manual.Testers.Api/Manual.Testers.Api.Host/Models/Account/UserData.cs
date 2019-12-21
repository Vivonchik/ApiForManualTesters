using System.ComponentModel.DataAnnotations;

namespace Manual.Testers.Api.Host.Models.Account
{
    public class UserData
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
