using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    // para usar IRepository deve ser filha de Entity
    // TEntity é um genérico
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        // métodos assíncronos
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);

        /*
         * uma expressão lambda que irá trabalhar com uma function
         * na qual recebe nossa entidade e faz uma comparação retornando boolean.
         * assim podemos buscar qualquer entidade por qualquer parâmetro
         * */
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}
