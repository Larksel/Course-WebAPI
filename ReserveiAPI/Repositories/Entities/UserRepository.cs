using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Contexts;
using ReserveiAPI.Objects.Models.Entities;
using ReserveiAPI.Repositories.Interfaces;

namespace ReserveiAPI.Repositories.Entities
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            return await _dbContext.Users.AsNoTracking().ToListAsync();
        }

        public async Task<UserModel> GetById(int id)
        {
            return await _dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserModel> Create(UserModel userModel)
        {
            _dbContext.Users.Add(userModel);
            await _dbContext.SaveChangesAsync();

            return userModel;
        }

        public async Task<UserModel> Update(UserModel userModel)
        {
            _dbContext.Entry(userModel).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return userModel;
        }

        public async Task<UserModel> Delete(UserModel userModel)
        {
            _dbContext.Users.Remove(userModel);
            await _dbContext.SaveChangesAsync();

            return userModel;
        }
    }
}
