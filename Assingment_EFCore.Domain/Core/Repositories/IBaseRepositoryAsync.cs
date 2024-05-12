﻿using Assingment_EFCore.Domain.Core.Models;
using Assingment_EFCore.Domain.Core.Specifications;

namespace Assingment_EFCore.Domain.Core.Repositories
{
    public interface IBaseRepositoryAsync<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);

        Task<List<T>> ListAllAsync();

        Task<IList<T>> ListAsync(ISpecification<T> spec);

        Task<T> FirstOrDefaultAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<int> CountAsync(ISpecification<T> spec);
    }
}