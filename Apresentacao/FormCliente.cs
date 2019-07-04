using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servico;
using System.Data.SqlClient;
using Servico.ServicosIndividuais;
using Modelo;

namespace Apresentacao
{
    public partial class FormCliente : Form
    {
        private ServicoCliente clienteservico = new ServicoCliente();
        public int codselecionado = -2;

        public FormCliente()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvCliente.DataSource = clienteservico.ObterTodosInclude();
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbIdade.Clear();
            tbEndereco.Clear();
            mkCPF.Clear();
            tbEmail.Clear();
            mkTelefone.Clear();
            tbBusca.Clear();
            mkCPFBusca.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvCliente.CurrentRow.Index;
            tbNome.Text = Convert.ToString(dgvCliente["nome", cont].Value);
            tbIdade.Text = Convert.ToString(dgvCliente["idade", cont].Value);
            tbEndereco.Text = Convert.ToString(dgvCliente["endereco", cont].Value);
            mkCPF.Text = Convert.ToString(dgvCliente["cpf", cont].Value);
            tbEmail.Text = Convert.ToString(dgvCliente["email", cont].Value);
            mkTelefone.Text = Convert.ToString(dgvCliente["telefone", cont].Value);
            codselecionado = Convert.ToInt16(dgvCliente["ClienteID", cont].Value);
            btCadastraPet.Enabled = true;
            btAtualizar.Enabled = true;
            btHistorico.Enabled = true;
            btContas.Enabled = true;
        }
        
        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private bool VerificaCPF(string cpf)
        {
            List<Cliente> clientes = clienteservico.Buscar(X => X.CPF == cpf).ToList();
            int res = clientes.Count();
            
            if (res == 0)
            {
               return true;
            } else
            {
               return false;
            }    
        } 

        private void btCadastro_Click(object sender, EventArgs e)
        {
            if (VerificaCPF(mkCPF.Text) == true)
            {
                try
                {
                    clienteservico.Gravar(
                    new Cliente()
                    {
                        Nome = tbNome.Text,
                        Idade = Convert.ToInt16(tbIdade.Text),
                        Endereco = tbEndereco.Text,
                        CPF = mkCPF.Text,
                        Email = tbEmail.Text,
                        Telefone = mkTelefone.Text
                    });
                }
                catch
                {
                    MessageBox.Show("Campos digitados de forma incorreta!");
                }
            } else
            {
                MessageBox.Show("CPF já existente!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
           try
            {
              clienteservico.Atualizar(
              new Cliente()
              {
                  ClienteID = codselecionado,
                  Nome = tbNome.Text,
                  Idade = Convert.ToInt16(tbIdade.Text),
                  Endereco = tbEndereco.Text,
                  CPF = mkCPF.Text,
                  Email = tbEmail.Text,
                  Telefone = mkTelefone.Text
              });
            }
            catch
            {
                MessageBox.Show("Selecione um cliente para atualizar!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {   
            try
            {
                if (tbBusca.Text != null && mkCPFBusca.Text != null)
                {
                    clienteservico.Excluir(X => X.CPF == mkCPFBusca.Text);
                    RefreshDataGridView();
                }
            } catch
            {
                MessageBox.Show("Por favor digite os dados do cliente a ser excluido!");
            }
            LimparCampos();

        }
        
        private void btCadastraPet_Click(object sender, EventArgs e)
        {
            try
            {
                FormAnimal formanimal = new FormAnimal(codselecionado, tbNome.Text);
                formanimal.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            catch
            {
                MessageBox.Show("Por favor selecione um cliente!");
            }
            LimparCampos();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = clienteservico.Buscar(X => X.Nome == tbBusca.Text).ToList();
            dgvCliente.DataSource = clientes;
            LimparCampos();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LimparCampos();
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            FormAgendaCliente formnew = new FormAgendaCliente(codselecionado);
            formnew.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btContas_Click(object sender, EventArgs e)
        {
            FormContasCliente formnew = new FormContasCliente(codselecionado);
            formnew.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbIdade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
