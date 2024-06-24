using ToDo.Api.Models;

namespace ToDo.Api.Repository;

public interface ITaskRepository
{
    List<TodoTask> Get();
    TodoTask Add(TodoTask todoTask);
    TodoTask Update(int Id, TodoTask todoTask);
    void Delete(int Id);
}