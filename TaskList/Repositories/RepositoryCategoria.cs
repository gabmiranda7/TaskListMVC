using TaskList.Models;

namespace TaskList.Repositories
{
    public class RepositoryCategoria : RepositoryBase<Categoria>
    {
        public RepositoryCategoria(AppDbContext contexto, bool saveChanges = true) : base(contexto, saveChanges)
        {
        }
    }
}
