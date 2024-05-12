using Assingment_EFCore.Domain.Core.Models;

namespace Assingment_EFCore.Domain.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        Task RollBackChangesAsync();

        IBaseRepositoryAsync<T> Repository<T>() where T : BaseEntity;
    }
}