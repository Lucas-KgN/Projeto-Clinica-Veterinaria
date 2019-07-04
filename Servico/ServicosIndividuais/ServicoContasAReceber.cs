using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoContasAReceber
    {
        private Repositorio<ContasAReceber> dados = new Repositorio<ContasAReceber>();

        public void Gravar(ContasAReceber contas)
        {
            dados.Gravar(contas);
        }

        public IQueryable<ContasAReceber> Buscar(Func<ContasAReceber, bool> par)
        {
            return dados.Buscar(par);
        }

        public IEnumerable<ContasAReceber> ObterTodosContas()
        {
            return dados.ObterTodos().ToList();
        }

        public void Atualizar(ContasAReceber conta)
        {
            dados.Atualizar(conta);
        }

        public IEnumerable<ContasAReceber> ObterTodasContasNaoPagas()
        {
            return dados.ObterTodos().Where(X => X.Pago == false).ToList();
        }

        public IEnumerable<ContasAReceber> ObterTodasContasDoCliente(int codcliente)
        {
            return dados.ObterTodos().Where(X => X.ClienteID == codcliente).ToList();
        }
    }
}
