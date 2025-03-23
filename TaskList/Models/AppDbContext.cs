using Microsoft.EntityFrameworkCore;

namespace TaskList.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Prioridade)
                .WithMany()
                .HasForeignKey(t => t.PrioridadeId);

            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Categoria)
                .WithMany()
                .HasForeignKey(t => t.CategoriaId);

            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Status)
                .WithMany()
                .HasForeignKey(t => t.StatusId);

            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Responsavel)
                .WithMany()
                .HasForeignKey(t => t.ResponsavelId);
        }
    }
}
