using Microsoft.EntityFrameworkCore;
using ToDo.Api.Models;

namespace ToDo.Api.Context;

public interface IDatabaseContext
{
    public DbSet<TodoTask> TodoTasks { get; set; }
    public int SaveChanges();
}