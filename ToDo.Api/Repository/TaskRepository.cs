using ToDo.Api.Context;
using ToDo.Api.Models;

namespace ToDo.Api.Repository;

public class TaskRepository : ITaskRepository
{
    protected readonly IDatabaseContext _context;

    public TaskRepository(IDatabaseContext context)
    {
        _context = context;
    }
    public List<TodoTask> Get()
    {
        return _context.TodoTasks.OrderByDescending(tt => tt.Id).ToList();
    }
    public TodoTask Add(TodoTask todoTask)
    {
        _context.TodoTasks.Add(todoTask);
        _context.SaveChanges();
        return todoTask;
    }
    public TodoTask Update(int Id, TodoTask todoTask)
    {
        TodoTask? existingTask = _context.TodoTasks.Find(Id);
        if (existingTask == null) throw new Exception("Task not found");
        existingTask.Description = todoTask.Description;
        existingTask.Status = todoTask.Status;
        _context.TodoTasks.Update(existingTask);
        _context.SaveChanges();
        return existingTask;
    }
    public void Delete(int Id)
    {
        TodoTask? existingTask = _context.TodoTasks.Find(Id);
        if (existingTask == null) throw new Exception("Task not found");
        _context.TodoTasks.Remove(existingTask);
        _context.SaveChanges();
    }
}