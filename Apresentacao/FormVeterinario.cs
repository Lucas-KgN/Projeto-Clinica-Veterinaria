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
    public partial class FormVeterinario : Form
    {
        private ServicoVeterinario vetservico = new ServicoVeterinario();
        private ServicoCliente clienteservico = new ServicoCliente();

        public int codselecionado = -2;

        public FormVeterinario()
        {
            InitializeComponent();
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            dgvVet.DataSource = vetservico.ObterTodosInclude();
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
       

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void FormVeterinario_Load(object sender, EventArgs e)
        {

        }

        private bool VerificaCPF(string cpf)
        {
            List<Veterinario> veterinarios = vetservico.Buscar(X => X.CPF == cpf).ToList();
            List<Cliente> clientes = clienteservico.Buscar(X => X.CPF == cpf).ToList();

            int rescli = clientes.Count();
            int resvet = veterinarios.Count();

            if (resvet == 0 && rescli == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btCadastro_Click_1(object sender, EventArgs e)
        {
            if(VerificaCPF(mkCPF.Text) == true)
            {
                try
                {
                    vetservico.Gravar(
                    new Veterinario()
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
                MessageBox.Show("CPF já cadastrado!");
            }
           

            LimparCampos();
            RefreshDataGridView();
        }

        private void dgvVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvVet.CurrentRow.Index;
            tbNome.Text = Convert.ToString(dgvVet["nome", cont].Value);
            tbIdade.Text = Convert.ToString(dgvVet["idade", cont].Value);
            tbEndereco.Text = Convert.ToString(dgvVet["endereco", cont].Value);
            mkCPF.Text = Convert.ToString(dgvVet["cpf", cont].Value);
            tbEmail.Text = Convert.ToString(dgvVet["email", cont].Value);
            mkTelefone.Text = Convert.ToString(dgvVet["telefone", cont].Value);
            codselecionado = Convert.ToInt16(dgvVet["VeterinarioID", cont].Value);
            btAtualizar.Enabled = true;
            btHistorico.Enabled = true;
        }

        private void btAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                vetservico.Atualizar(
                new Veterinario()
                {
                    VeterinarioID = codselecionado,
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
                MessageBox.Show("Selecione um Veterinario para atualizar!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbBusca.Text != null && mkCPFBusca.Text != null)
                {
                    vetservico.Excluir(X => X.CPF == mkCPFBusca.Text);
                    RefreshDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Por favor digite os dados do veterinário a ser excluido!");
            }
            LimparCampos();
        }

        private void btBusca_Click_1(object sender, EventArgs e)
        {
            List<Veterinario> veterinarios = vetservico.Buscar(X => X.Nome == tbBusca.Text).ToList();
            dgvVet.DataSource = veterinarios;
            LimparCampos();
        }

        private void btLista_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LimparCampos();
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            FormAgendaVet formnew = new FormAgendaVet(codselecionado);
            formnew.Show();
            LimparCampos();
            RefreshDataGridView();
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
