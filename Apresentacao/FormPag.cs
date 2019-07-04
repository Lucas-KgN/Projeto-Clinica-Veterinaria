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
    public partial class FormPag : Form
    {
        private ServicoContasAReceber servicocontas = new ServicoContasAReceber();
        private ServicoCaixa servicocaixa = new ServicoCaixa();
        private double valor;

        private int codconta;
        public int codcliente;
        private DateTime data;

        public FormPag()
        {
            InitializeComponent();
            RefreshDataGridView();
            valor = 0;
            RetornaCaixa();
        }

        private void RefreshDataGridView()
        {
            dgvPagamentos.DataSource = servicocontas.ObterTodasContasNaoPagas();
        }

        private void FormPag_Load(object sender, EventArgs e)
        {

        }

        private void dgvPagamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvPagamentos.CurrentRow.Index;
            tbCliente.Text = Convert.ToString(dgvPagamentos["nomecliente", cont].Value);
            tbValor.Text = Convert.ToString(dgvPagamentos["valor", cont].Value);
            codcliente = Convert.ToInt16(dgvPagamentos["ClienteID", cont].Value);
            codconta = Convert.ToInt16(dgvPagamentos["ContasAReceberID", cont].Value);
            data = Convert.ToDateTime(dgvPagamentos["data", cont].Value);
            btConfirmar.Enabled = true;
        }

        private void LimparCampos()
        {
            tbCliente.Text = null;
            tbValor.Text = null;
            tbBusca.Text = null;
        }

        private void RetornaCaixa()
        {
            List<ContasAReceber> registros = servicocontas.Buscar(X => X.Pago == true).ToList();
            foreach(ContasAReceber a in registros)
            {
                valor += a.Valor;
            }
        }

        private void VerificaData()
        {
            if (data == null)
            {
                data = DateTime.Today;
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            valor += Convert.ToDouble(tbValor.Text);
            VerificaData();

            try
            {
                servicocontas.Atualizar(
                new ContasAReceber()
                {   
                    ContasAReceberID = codconta,
                    ClienteID = codcliente,
                    NomeCliente = tbCliente.Text,
                    Valor = Convert.ToDouble(tbValor.Text),
                    Pago = true,
                    Data = data
                });
                MessageBox.Show("Pagamento Confirmado!");
                servicocaixa.Gravar(
                   new Caixa()
                   {
                       ContasAReceberID = codconta,
                       ValorTotal = valor,
                       Data = DateTime.Today
                   });
            }
            catch
            {
                MessageBox.Show("Selecione uma conta para Pagar!");
            }
            LimparCampos();
            RefreshDataGridView();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            List<ContasAReceber> contascliente = servicocontas.Buscar(X => X.NomeCliente == tbBusca.Text).ToList();
            dgvPagamentos.DataSource = contascliente;
            LimparCampos();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LimparCampos();
        }
    }
}
