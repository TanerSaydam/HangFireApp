using Microsoft.EntityFrameworkCore;

namespace HangFireApp.Context
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
