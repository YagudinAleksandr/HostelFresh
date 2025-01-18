using HostelFresh.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HostelFresh.Shared.Common.Dtos.Users
{
    /// <summary>
    /// DTO пользователя
    /// </summary>
    public record UserDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Имя пользователя должно быть заполнено")]
        [StringLength(60, ErrorMessage = "Имя не может содержать более 60 символов")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "E-mail не может быть пустым")]
        [EmailAddress(ErrorMessage = "E-mail должен быть действительным адресом")]
        [StringLength(60, ErrorMessage = "E-mail не может содержать более 60 символов")]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Номер телефона
        /// </summary>
        [StringLength(20, ErrorMessage = "Номер телефона не может содержать более 20 символов")]
        public string Phone { get; set; } = null!;

        /// <summary>
        /// Нормализованное имя пользователя в верхнем регистре
        /// </summary>
        [Required(ErrorMessage = "Имя пользователя должно быть заполнено")]
        [StringLength(60, ErrorMessage = "Имя пользователя не может содержать более 60 символов")]
        public string NormilizedUsername { get; set; } = null!;

        /// <summary>
        /// Тип пользователя <see cref="UserTypes"/>
        /// </summary>
        public UserTypes Type { get; set; }

        /// <summary>
        /// Статус активности пользователя
        /// </summary>
        public UserStatusTypes Status { get; set; }
    }
}
