using Microsoft.EntityFrameworkCore;
using ToDo.Api.Models;

namespace ToDo.Api.Context;


public class DatabaseContext : DbContext, IDatabaseContext
{
    public DbSet<TodoTask> TodoTasks { get; set; } = null!;
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=db;Database=Todo;User=SA;Password=TodoApiSqlPass123!;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    
}