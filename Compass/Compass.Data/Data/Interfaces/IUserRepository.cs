using Compass.Data.Data.Models;
using Compass.Data.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compass.Data.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<IdentityResult> RegisterUserAsync(AppUser model, string password, string role);
        Task<AppUser> LoginUserAsync(LoginUserVM model);
        Task<bool> ValidatePasswordAsync(LoginUserVM model, string password);
        Task<string> GenerateEmailConfirmationTokenAsync(AppUser appUser);
        Task<AppUser> GetUserByIdAsync(string id);
        Task<IList<string>> GetRolesAsync(AppUser model);
        Task<AppUser> GetUserByEmailAsync(string email);
        Task<IdentityResult> ConfirmEmailAsync(AppUser model, string token);
        Task<string> GeneratePasswordResetTokenAsync(AppUser model);
        Task<IdentityResult> ResetPasswordAsync(AppUser model, string token, string password);
        Task SaveRefreshTokenAsync(RefreshToken refreshToken);
        Task<RefreshToken> CheckRefreshTokenAsync(string refreshToken);
        Task UpdateRefreshTokenAsync(RefreshToken refreshToken);
        Task<List<AppUser>> GetAllUsersAsync();
        Task<IdentityResult> DeleteUserAsync(AppUser model);
        Task<IdentityResult> UpdateUserAsync(AppUser model);
    }
}
