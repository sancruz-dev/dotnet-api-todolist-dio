using Microsoft.EntityFrameworkCore;
using TodoList.Entities;

namespace TodoList.Context
{
    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
