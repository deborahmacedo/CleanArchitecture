using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Read(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<T> Get(Guid id, CancellationToken cancellationToken); //obter usarios pelo id
        Task<List<T>> GetAll(CancellationToken cancellationToken); //obter umas lista com todos os usuários

    }
}
