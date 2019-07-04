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
    public partial class FormContasCliente : Form
    {
        private int codcliente;
        private int codconta;
        private string nomecliente;
        private bool pago;

        private ServicoContasAReceber servicocontas = new ServicoContasAReceber();

        public FormContasCliente(int codcliente)
        {
            InitializeComponent();
            this.codcliente = codcliente;
            RefreshDataGridView();
        }

        private void FormContasCliente_Load(object sender, EventArgs e)
        {

        }

        private void RefreshDataGridView()
        {
            dgvContas.DataSource = servicocontas.ObterTodasContasDoCliente(codcliente);
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            btConfirmar.Enabled = true;
            btPagamento.Enabled = true;
        }

        private void dgvContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvContas.CurrentRow.Index;
            tbValor.Text = Convert.ToString(dgvContas["valor", cont].Value);
            codconta = Convert.ToInt16(dgvContas["ContasAReceberID", cont].Value);
            mkData.Text = Convert.ToString(dgvContas["data", cont].Value);
            nomecliente = Convert.ToString(dgvContas["nomecliente", cont].Value);
            pago = Convert.ToBoolean(dgvContas["pago", cont].Value);
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            var data = calendario.SelectionStart.Day.ToString() + "/" + calendario.SelectionStart.Month.ToString() + "/" + calendario.SelectionStart.Year.ToString();
            try
            {
                servicocontas.Atualizar(
                new ContasAReceber()
                {
                    ContasAReceberID = codconta,
                    ClienteID = codcliente,
                    NomeCliente = nomecliente,
                    Data = Convert.ToDateTime(data),
                    Valor = Convert.ToDouble(tbValor.Text),
                    Pago = this.pago
                });
                MessageBox.Show("Data confirmada!");
            }
            catch
            {
                MessageBox.Show("Selecione um cliente para atualizar!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void LimparCampos()
        {
            tbValor.Text = null;
            mkData.Text = null;
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            FormPag formnew = new FormPag();
            formnew.Show();
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            mkData.Text = Convert.ToString(calendario.SelectionStart);
        }

        private void mkData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormContasCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCliente formnew = new FormCliente();
            formnew.Show();
        }
    }
}
