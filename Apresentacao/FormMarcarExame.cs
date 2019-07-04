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
using Servico;

namespace Apresentacao
{
    public partial class FormMarcarExame : Form
    {
        private int codcliente;
        private int codpet;
        private int codexame;
        private string nomecliente;
        private string nomepet;
        private DateTime data;

        private ServicoExame servicoexame = new ServicoExame();
        private ServicoProcedimento servicoprocedimento = new ServicoProcedimento();
        private ServicoContasAReceber servicocontas = new ServicoContasAReceber();


        public FormMarcarExame(int codcliente, int codpet, string nomecliente, string nomepet)
        {
            InitializeComponent();
            RefreshDataGridView();
            this.codcliente = codcliente;
            this.codpet = codpet;
            this.nomecliente = nomecliente;
            this.nomepet = nomepet;
        }

        private void RefreshDataGridView()
        {
            dgvExames.DataSource = servicoexame.ObterTodosExames();
        }

        private void FormMarcarExame_Load(object sender, EventArgs e)
        {

        }

        private void dgvExames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvExames.CurrentRow.Index;
            tbNome.Text = Convert.ToString(dgvExames["nomeexame", cont].Value);
            tbDono.Text = nomecliente;
            tbPet.Text = nomepet;
            tbObjetivo.Text = Convert.ToString(dgvExames["objetivo", cont].Value);
            tbTempo.Text = Convert.ToString(dgvExames["tempoexecucao", cont].Value);
            tbValor.Text = Convert.ToString(dgvExames["valor", cont].Value);
            codexame = Convert.ToInt16(dgvExames["ExameID", cont].Value);
        }

        private void btData_Click(object sender, EventArgs e)
        {
            var data = mcData.SelectionStart.Day.ToString() + "/" + mcData.SelectionStart.Month.ToString() + "/" + mcData.SelectionStart.Year.ToString();
            tbData.Text = data;
            btConfirmar.Enabled = true;
            this.data = Convert.ToDateTime(data);
            tbData.Enabled = true;
        }

        private void LimparCampos()
        {
            tbDono.Text = null;
            tbPet.Text = null;
            tbNome.Text = null;
            tbObjetivo.Text = null;
            tbTempo.Text = null;
            tbValor.Text = null;
            tbData.Text = null;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                servicoprocedimento.Gravar(
                new Procedimento()
                {
                    ExameID = codexame,
                    ClienteID = codcliente,
                    AnimalID = codpet,
                    Data = data
                });
                servicocontas.Gravar(
                 new ContasAReceber()
                 {
                    ClienteID = codcliente,
                    Pago = false,
                    Valor = Convert.ToDouble(tbValor.Text),
                    NomeCliente = tbDono.Text
                 });
                MessageBox.Show("Exame confirmado!");
            }
            catch
            {
                MessageBox.Show("Campos em Branco!");
            }
            LimparCampos();

        }

        private void mcData_DateChanged(object sender, DateRangeEventArgs e)
        {
            btData.Enabled = true;
        }

        private void FormMarcarExame_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPosConsulta formnew = new FormPosConsulta();
            formnew.Show();
        }
        
    }
}
