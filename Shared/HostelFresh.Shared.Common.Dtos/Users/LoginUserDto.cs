using System.ComponentModel.DataAnnotations;

namespace HostelFresh.Shared.Common.Dtos.Users
{
    /// <summary>
    /// Авторизация пользователя
    /// </summary>
    public record LoginUserDto
    {
        /// <summary>
        /// E-mail
        /// </summary>
        [Required(ErrorMessage = "E-mail должен быть указан")]
        [StringLength(60, ErrorMessage = "E-mail не может содержать более 60 символов")]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Пароль не может быть пустым")]
        [StringLength(255, ErrorMessage = "Пароль не может содержать более 255 символов")]
        public string Password { get; set; } = null!;
    }
}
