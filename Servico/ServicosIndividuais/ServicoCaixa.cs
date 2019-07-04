using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoCaixa
    {
        private Repositorio<Caixa> dados = new Repositorio<Caixa>();

        public void Gravar(Caixa registro)
        {
            dados.Gravar(registro);
        }
        
        public void Atualizar(Caixa registro)
        {
            dados.Atualizar(registro);
        }

        public IEnumerable<Caixa> ObterTodosRegistros()
        {
            return dados.ObterTodos().ToList();
        }

        public IQueryable<Caixa> Buscar(Func<Caixa, bool> valor)
        {
            return dados.Buscar(valor);
        }

    }
}
