using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using Persistencia;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoCliente
    { 
        private Repositorio<Cliente> dados = new Repositorio<Cliente>();

        public void Gravar(Cliente cliente)
        {
            dados.Gravar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            dados.Atualizar(cliente);
        }
        
        public void Excluir(Func<Cliente, bool> cpf)
        {
            dados.Excluir(cpf);
        }

        public IQueryable<Cliente> Buscar(Func<Cliente, bool> nome)
        {
            return dados.Buscar(nome);
        }
        
        public IEnumerable<Cliente> ObterTodosInclude()
        {
            return dados.ObterTodos();
        }
        
    }
}
