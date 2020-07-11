using Microsoft.EntityFrameworkCore;

namespace WebAppEditorWebApi.Models
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<Notice> Notice { get; set; }
    }
}
