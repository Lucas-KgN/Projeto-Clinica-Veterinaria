using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> ObterTodos();
        IQueryable<T> Buscar(Func<T, bool> predicate);

        void Gravar(T entidade);
        void Atualizar(T entidade);
        void Excluir(Func<T, bool> predicate);
        void SalvarMundancas();
    }
}
