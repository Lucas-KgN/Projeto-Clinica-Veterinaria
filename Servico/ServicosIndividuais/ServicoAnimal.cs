using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicosIndividuais
{
    public class ServicoAnimal
    {
        private Repositorio<Animal> dados = new Repositorio<Animal>();

        public void Gravar(Animal animal)
        {
            dados.Gravar(animal);
        }

        public IQueryable<Animal> Buscar(Func<Animal, bool> nome)
        {
            return dados.Buscar(nome);
        }

        public void Atualizar(Animal animal)
        {
            dados.Atualizar(animal);
        }

        public IEnumerable<Animal> ObterTodosPetsPorCliente(int codcliente)
        {
            return dados.ObterTodos().Where(X=>X.ClienteID == codcliente).ToList();
        }

        public IEnumerable<Animal> ObterTodosPets()
        {
            return dados.ObterTodos().ToList();
        }
    }
}
