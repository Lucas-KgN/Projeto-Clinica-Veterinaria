using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoProcedimento
    {
        private Repositorio<Procedimento> dados = new Repositorio<Procedimento>();

        public void Gravar(Procedimento procedimento)
        {
            dados.Gravar(procedimento);
        }
        
        public IQueryable<Procedimento> Buscar(Func<Procedimento, bool> nome)
        {
            return dados.Buscar(nome);
        }

        public IEnumerable<Procedimento> ObterTodosProcedimentos()
        {
            return dados.ObterTodos();
        }

        public void Atualizar(Procedimento procedimento)
        {
            dados.Atualizar(procedimento);
        }
    }
}
