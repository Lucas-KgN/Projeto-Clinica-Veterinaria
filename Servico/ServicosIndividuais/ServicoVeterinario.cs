using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoVeterinario
    {
        private Repositorio<Veterinario> dados = new Repositorio<Veterinario>();

        public void Gravar(Veterinario veterinario)
        {
            dados.Gravar(veterinario);
        }

        public void Atualizar(Veterinario veterinario)
        {
            dados.Atualizar(veterinario);
        }

        public void Excluir(Func<Veterinario, bool> cpf)
        {
            dados.Excluir(cpf);
        }

        public IQueryable<Veterinario> Buscar(Func<Veterinario, bool> nome)
        {
            return dados.Buscar(nome);
        }

        public IEnumerable<Veterinario> ObterTodosInclude()
        {
            return dados.ObterTodos();
        }
    }
}
