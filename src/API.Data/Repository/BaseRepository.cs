using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data.Context;
using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Data.Repository
{
    //recebe uma entidade(<T>)
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity //no IRepository<T> colocar implementação da interface
    {
        protected readonly MyContext _context; //_context é a variável
        public BaseRepository(MyContext context)//construtor
        {
            _context = context;
        }
        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<T> SelectAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
