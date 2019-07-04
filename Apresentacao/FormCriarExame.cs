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
    public partial class FormCriarExame : Form
    {
        private ServicoExame exameservico = new ServicoExame();
        public int codselecionado = -2;

        public FormCriarExame()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void LimparCampos()
        {
            tbNome.Text = null;
            tbObjetivo.Text = null;
            tbTempo.Text = null;
            tbValor.Text = null;
        }

        private void RefreshDataGridView()
        {
            dgvExames.DataSource = exameservico.ObterTodosExames();
        }

        private void FormCriarExame_Load(object sender, EventArgs e)
        {

        }

        private void dgvExames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvExames.CurrentRow.Index;
            tbNome.Text = Convert.ToString(dgvExames["nomeexame", cont].Value);
            tbObjetivo.Text = Convert.ToString(dgvExames["objetivo", cont].Value);
            tbTempo.Text = Convert.ToString(dgvExames["tempoexecucao", cont].Value);
            tbValor.Text = Convert.ToString(dgvExames["valor", cont].Value);
            codselecionado = Convert.ToInt16(dgvExames["ExameID", cont].Value);
            btAtualizar.Enabled = true;
        }

        private bool VerificaExame(string nome)
        {
            List<Exame> exames = exameservico.Buscar(X => X.NomeExame == nome).ToList();
            int res = exames.Count();

            if (res == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {   
            if (VerificaExame(tbNome.Text) == true)
            {
                try
                {
                    exameservico.Gravar(
                    new Exame()
                    {
                        NomeExame = tbNome.Text,
                        Objetivo = tbObjetivo.Text,
                        TempoExecucao = tbTempo.Text,
                        Valor = Convert.ToDouble(tbValor.Text)
                    });
                }
                catch
                {
                    MessageBox.Show("Campos em Branco!");
                }
            }
            else
            {
                MessageBox.Show("Exame já existente!");
            }
            
            LimparCampos();
            RefreshDataGridView();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                exameservico.Atualizar(
                new Exame()
                {   
                    ExameID = codselecionado,
                    NomeExame = tbNome.Text,
                    Objetivo = tbObjetivo.Text,
                    TempoExecucao = tbTempo.Text,
                    Valor = Convert.ToDouble(tbValor.Text)
                });
            }
            catch
            {
                MessageBox.Show("Selecione um Exame para atualizar!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbBusca.Text != null)
                {
                    exameservico.Excluir(X => X.NomeExame == tbBusca.Text);
                    RefreshDataGridView();
                }
            }
            catch
            {
                MessageBox.Show("Por favor digite o nome do Exame a ser excluido!");
            }
            LimparCampos();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            List<Exame> exames = exameservico.Buscar(X => X.NomeExame == tbBusca.Text).ToList();
            dgvExames.DataSource = exames;
            LimparCampos();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LimparCampos();
        }

        private void btAgendados_Click(object sender, EventArgs e)
        {
            FormExamesAgendados formnew = new FormExamesAgendados();
            formnew.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
