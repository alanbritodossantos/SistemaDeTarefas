using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContext: DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext>options) 
            : base (options) 
        {
                
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TarefaModel>();
        }
    }
}
