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
    public partial class FormCaixa : Form
    {
        private ServicoCaixa servicocaixa = new ServicoCaixa();
        private ServicoContasAReceber servicocontas = new ServicoContasAReceber();
        private int codigo;

        public FormCaixa()
        {
            InitializeComponent();
            RefreshDataGridViewGeral();
            RefreshDataGridViewCaixa();
            
        }

        private void RefreshDataGridViewGeral()
        {   
            dgvGeral.DataSource = servicocontas.ObterTodosContas();
            dgvGeral.Columns["ClienteID"].Visible = false;
        }
        
        private void RefreshDataGridViewCaixa()
        {
            dgvCaixa.DataSource = servicocaixa.ObterTodosRegistros();
        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            dgvGeral.ClearSelection();
            dgvCaixa.ClearSelection();
        }

        private void dgvCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int cont = dgvCaixa.CurrentRow.Index;
            lbValorFinal.Text = Convert.ToString(dgvCaixa["valortotal", cont].Value) + " Reais";
            codigo = Convert.ToInt16(dgvCaixa["ContasAReceberID", cont].Value);
            for (int i = 0; i < dgvGeral.Rows.Count; i++)
            {
                if (codigo == Convert.ToInt16(dgvGeral["ContasAReceberID", i].Value))
                {
                    dgvGeral.Rows[i].DefaultCellStyle.BackColor = Color.Red; 
                } else
                {
                    dgvGeral.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            dgvGeral.ClearSelection();
        }

        private void lbValorFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
