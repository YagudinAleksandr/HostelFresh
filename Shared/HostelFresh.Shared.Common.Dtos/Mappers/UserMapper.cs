using AutoMapper;
using HostelFresh.Domain.Entities;
using HostelFresh.Shared.Common.Dtos.Users;

namespace HostelFresh.Shared.Common.Dtos.Mappers
{
    /// <summary>
    /// Маппер пользователей
    /// </summary>
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            /// User -> UserDto
            CreateMap<User, UserDto>();

            /// LoginUserDto -> User
            CreateMap<LoginUserDto, User>();
        }
    }
}
