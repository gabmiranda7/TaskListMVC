using TaskList.Models;

namespace TaskList.Repositories
{
    public class RepositoryPrioridade : RepositoryBase<Prioridade>
    {
        public RepositoryPrioridade(AppDbContext contexto, bool saveChanges = true) : base(contexto, saveChanges)
        {
        }
    }
}
