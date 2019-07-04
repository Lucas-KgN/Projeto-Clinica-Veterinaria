using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : class
    {
        private EFContext Contexto;

        public IEnumerable<T> ObterTodos()
        {
            using (Contexto = new EFContext())
            {
                return Contexto.Set<T>().ToList();
            }
        }

        public IQueryable<T> Buscar(Func<T, bool> predicate)
        {
            using (Contexto = new EFContext())
            {
                return ObterTodos().Where(predicate).AsQueryable();
            }
        }
        
        public void Gravar(T entidade)
        {
            using (Contexto = new EFContext())
            {

                Contexto.Set<T>().Add(entidade);
                this.SalvarMundancas();
            }
            
        }

        public void Atualizar(T entidade)
        {

            using (Contexto = new EFContext())
            {
                Contexto.Entry(entidade).State = EntityState.Modified;
                this.SalvarMundancas();
            }

        }

        public void Excluir(Func<T, bool> predicate)
        {
            using (Contexto = new EFContext())
            {
                Contexto.Set<T>().Where(predicate).ToList().ForEach(del => Contexto.Set<T>().Remove(del));
                Contexto.SaveChanges();
            }

        }

        public void SalvarMundancas()
        {
            Contexto.SaveChanges();
        }

        public void Dispose()
        {
            Contexto.Dispose();
        }
    }
}
