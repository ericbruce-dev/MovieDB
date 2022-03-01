using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieDB.Data;
using MovieDB.Models.Database;
using MovieDB.Models.Settings;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.Services
{
    public class SeedService
    {
        private readonly AppSettings _appSettings;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedService(IOptions<AppSettings> appSettings, ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _appSettings = appSettings.Value;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task ManageDataAsync()
        {
            await UpdateDatabaseAsync();
            await SeedRolesAsync();
            await SeedUsersAsync();
            await SeedCollections();
        }

        private async Task UpdateDatabaseAsync()
        {
            await _context.Database.MigrateAsync();
        }

        private async Task SeedRolesAsync()
        {
            if (_context.Roles.Any()) return;

            var adminRole = _appSettings.MovieDbSettings.DefaultCredentials.Role;

            await _roleManager.CreateAsync(new IdentityRole(adminRole));
        }

        private async Task SeedUsersAsync()
        {
            if (_userManager.Users.Any()) return;

            var credentials = _appSettings.MovieDbSettings.DefaultCredentials;
            var newUser = new IdentityUser()
            {
                Email = credentials.Email,
                UserName = credentials.Email,
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(newUser, credentials.Password);
            await _userManager.AddToRoleAsync(newUser, credentials.Role);
        }

        private async Task SeedCollections()
        {
            if (_context.Collection.Any()) return;

            _context.Add(new Collection()
            {
                Name = _appSettings.MovieDbSettings.DefaultCollection.Name,
                Description = _appSettings.MovieDbSettings.DefaultCollection.Description
            });

            await _context.SaveChangesAsync();
        }
    }
}
