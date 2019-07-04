using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico
{
    public class ServicoExame
    {
        private Repositorio<Exame> dados = new Repositorio<Exame>();

        public void Gravar(Exame exame)
        {
            dados.Gravar(exame);
        }

        public void Atualizar(Exame exame)
        {
            dados.Atualizar(exame);
        }

        public void Excluir(Func<Exame, bool> nome)
        {
            dados.Excluir(nome);
        }

        public IQueryable<Exame> Buscar(Func<Exame, bool> nome)
        {
            return dados.Buscar(nome);
        }

        public IEnumerable<Exame> ObterTodosExames()
        {
            return dados.ObterTodos();
        }

    }
}
