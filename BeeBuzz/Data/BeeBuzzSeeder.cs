using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace BeeBuzz.Data
{
    public class BeeBuzzSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public BeeBuzzSeeder(ApplicationDbContext context,
            IWebHostEnvironment hosting,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _hosting = hosting;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureCreated();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Organization"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));
            }



            _db.SaveChanges();  
        }
    }
}
