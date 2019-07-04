using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico.ServicosIndividuais;
using Modelo;

namespace Apresentacao
{
    public partial class FormAnimal : Form
    {
        private ServicoAnimal servicoanimal = new ServicoAnimal();
        public int codcliente { get; set; }
        public int codpet { get; set; }
        public string nomecliente { get; set; }        

        public FormAnimal(int codcliente, string nomecliente)
        {   
            this.nomecliente = nomecliente;
            this.codcliente = codcliente;
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvPet.DataSource = servicoanimal.ObterTodosPetsPorCliente(codcliente);
        }

        private void FormAnimal_Load(object sender, EventArgs e)
        {

        }
        
        private void LimparCampos()
        {
            tbNome.Clear();
            tbIdade.Clear();
            tbTipo.Clear();
            tbRaca.Clear();
            tbBuscaNome.Clear();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                servicoanimal.Gravar(
                new Animal()
                {
                    ClienteID = this.codcliente,
                    Nome = tbNome.Text,
                    Idade = Convert.ToDouble(tbIdade.Text),
                    Tipo = tbTipo.Text,
                    Raca = tbRaca.Text
                });
            } catch
            {
                MessageBox.Show("Campos digitados de forma incorreta!");
            }
            
            LimparCampos();
            RefreshDataGridView();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {   
            List<Animal> animais = servicoanimal.Buscar(X => X.Nome == tbBuscaNome.Text).ToList();
            dgvPet.DataSource = animais;
            LimparCampos();
        }

        private void btListaPets_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LimparCampos();
        }

        private void dgvPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvPet.CurrentRow.Index;
            tbNome.Text = Convert.ToString(dgvPet["nome", cont].Value);
            tbIdade.Text = Convert.ToString(dgvPet["idade", cont].Value);
            tbTipo.Text = Convert.ToString(dgvPet["tipo", cont].Value);
            tbRaca.Text = Convert.ToString(dgvPet["raca", cont].Value);
            codpet = Convert.ToInt16(dgvPet["AnimalID", cont].Value);
            codcliente = Convert.ToInt16(dgvPet["ClienteID", cont].Value);
            btConsulta.Enabled = true;
            btHistorico.Enabled = true;
            btExames.Enabled = true;
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {   
            if (tbNome.Text != null)
            {
                FormMarcarConsulta formnew = new FormMarcarConsulta(nomecliente, tbNome.Text, codcliente, codpet);
                formnew.Show();
            } else
            {
                MessageBox.Show("Selecione um pet!");
            }
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProntuarioPet formnew = new FormProntuarioPet(codpet);
            formnew.Show();
            
        }

        private void btExames_Click(object sender, EventArgs e)
        {
            FormExamesAgendadosPet formnew = new FormExamesAgendadosPet(codpet);
            formnew.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                servicoanimal.Atualizar(
                new Animal()
                {   
                    AnimalID = codpet,
                    ClienteID = this.codcliente,
                    Nome = tbNome.Text,
                    Idade = Convert.ToDouble(tbIdade.Text),
                    Tipo = tbTipo.Text,
                    Raca = tbRaca.Text
                });
            }
            catch
            {
                MessageBox.Show("Selecione um Pet para atualizar!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void FormAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCliente fornew = new FormCliente();
            fornew.Show();
        }
    }
}
