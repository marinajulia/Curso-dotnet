using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{//como vai ser uma interface de um repositório, ela deve ser um repositório padrão
 //o T no IRepository representa um repositório genérico
    public interface IRepository<T> where T : BaseEntity //onde T seja um tipo de BaseEntity //use api domain Entities // poser ser qualquer letra
    {
        //Task será uma tarefa
        //InsertAsync faz com que pode executar vários de uma vez
        //colocar Threading na task
        //nas tasks são devovidos os "T"
        Task<T> InsertAsync(T item); //aqui ele receber uma entidade(t) parametro (item)
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);//using system 
        Task<T> SelectAsync(Guid id);
        //vai trazer uma lista com o IEnumerable
        Task<IEnumerable<T>> SelectAsync(); //System.Collections.Generic;
    }
}
