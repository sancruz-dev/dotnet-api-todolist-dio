using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoList.Enums;

namespace TodoList.Entities
{
    public class Tarefa 
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }
        
        public string? Descricao{ get; set; }
        
        public DateTime Data { get; set; }

        public StatusEnum Status { get; set; }
    }
}
