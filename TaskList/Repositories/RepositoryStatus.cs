using TaskList.Models;

namespace TaskList.Repositories
{
    public class RepositoryStatus : RepositoryBase<Status>
    {
        public RepositoryStatus(AppDbContext contexto, bool saveChanges = true) : base(contexto, saveChanges)
        {
        }
    }
}
