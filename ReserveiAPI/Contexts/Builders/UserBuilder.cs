using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts.Builders
{
    public class UserBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            // Builder
            modelBuilder.Entity<UserModel>().HasKey(u => u.Id);
            modelBuilder.Entity<UserModel>().Property(u => u.ImageProfile);
            modelBuilder.Entity<UserModel>().Property(u => u.NameUser).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<UserModel>().Property(u => u.EmailUser).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<UserModel>().Property(u => u.PasswordUser).HasMaxLength(256).IsRequired();
            modelBuilder.Entity<UserModel>().Property(u => u.PhoneUser).HasMaxLength(15).IsRequired();

            // Inserções
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    Id = 1,
                    NameUser = "Master",
                    EmailUser = "master@development.com",
                    PasswordUser = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f",
                    PhoneUser = "(00) 00000-0000",
                    ImageProfile = ""
                }
            );
        }
    }
}
