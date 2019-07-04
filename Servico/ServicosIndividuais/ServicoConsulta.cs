using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoConsulta
    {
        private Repositorio<Consulta> dados = new Repositorio<Consulta>();

        public void Gravar(Consulta consulta)
        {
            dados.Gravar(consulta);
        }

        public IQueryable<Consulta> Buscar(Func<Consulta, bool> nomecliente)
        {
            return dados.Buscar(nomecliente);
        }

        public IEnumerable<Consulta> ObterTodosInclude()
        {
            return dados.ObterTodos();
        }

        public IEnumerable<Consulta> ObterTodosSemPos()
        {
            return dados.ObterTodos().Where(X=>X.Resumo == null).ToList();;
        }

        public void Atualizar(Consulta consulta)
        {
            dados.Atualizar(consulta);
        }

        public IQueryable<Consulta> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            return dados.Buscar(X => X.Data.Date >= dataInicio.Date && X.Data.Date <= dataFim.Date);
        }
        
    }
}
