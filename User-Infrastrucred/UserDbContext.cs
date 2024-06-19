using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Users_Domain.Entities;

namespace User_Infrastructure
{
    public class UserDbContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<User> Users { get; set; }

        public UserDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var connectionString = _configuration.GetConnectionString(typeDatabase!);

            if (typeDatabase == "SqlServer")
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    }
}
