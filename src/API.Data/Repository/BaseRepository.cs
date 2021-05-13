using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data.Context;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{
    //recebe uma entidade(<T>)
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity //no IRepository<T> colocar implementação da interface
    {
        protected readonly MyContext _context; //_context é a variável
        private DbSet<T> _dataset;

        public BaseRepository(MyContext context)//construtor
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {//Empty é vazio--- se for vazio, ele vai atribuir um novo Guid
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return item;
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
