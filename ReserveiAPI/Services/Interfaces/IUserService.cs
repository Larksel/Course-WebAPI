using ReserveiAPI.Objects.DTOs.Entities;

namespace ReserveiAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDTO> GetById(int id);
        Task Create(UserDTO userDTO);
        Task Update(UserDTO userDTO);
        Task Delete(UserDTO userDTO);
    }
}
