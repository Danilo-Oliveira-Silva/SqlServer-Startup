using System.ComponentModel.DataAnnotations;
using ToDo.Api.Types;

namespace ToDo.Api.Models;

public class TodoTask
{
    [Key]
    public int Id { get; set; }
    public string? Description { get; set; }
    public StatusTask? Status { get; set; }
}