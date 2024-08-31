using ReserveiAPI.Objects.Contracts;
using ReserveiAPI.Objects.DTOs.Entities;

namespace ReserveiAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDTO> GetById(int id);
        Task<UserDTO> GetByEmail(string email);
        Task<UserDTO> Login(Login login);
        Task Create(UserDTO userDTO);
        Task Update(UserDTO userDTO);
        Task Delete(UserDTO userDTO);
    }
}
