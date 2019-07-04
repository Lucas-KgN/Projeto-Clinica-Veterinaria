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
    public partial class FormPosConsulta : Form
    {
        private ServicoConsulta servicoconsulta = new ServicoConsulta();
        private ServicoContasAReceber servicocontas = new ServicoContasAReceber();
        private int codconsulta; 
        private int codpet;
        private int codcliente;
        private int codveterinario;
        private string nomecliente;
        private string nomepet;
        private double val;

        public FormPosConsulta()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dgvConsulta.DataSource = servicoconsulta.ObterTodosSemPos();
            dgvConsulta.Columns["ClienteID"].Visible = false;
            dgvConsulta.Columns["AnimalID"].Visible = false;
            dgvConsulta.Columns["VeterinarioID"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerificaValor()
        {
            val = Convert.ToDouble(tbValor.Text);

            if (Convert.ToDouble(tbValor.Text) < 0)
            {
                val = val * -1;
                tbValor.Text = Convert.ToString(val);
                MessageBox.Show("Atenção! Valor da consulta negativo! Mais atenção na proxima!");
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            VerificaValor();

            try
            {   
                servicoconsulta.Atualizar(
                new Consulta()
                {
                    ConsultaID = codconsulta,
                    VeterinarioID = codveterinario,
                    ClienteID = codcliente,
                    AnimalID = codpet,
                    NomeDono = tbDono.Text,
                    NomePet = tbPet.Text,
                    NomeVeterinario = tbVet.Text,
                    Data = Convert.ToDateTime(tbData.Text),
                    Resumo = tbResumo.Text,
                    Remedios = tbRemedios.Text,
                    ValorConsulta = Convert.ToDouble(tbValor.Text)
                });
                servicocontas.Gravar(
                new ContasAReceber()
                {
                    ClienteID = codcliente,
                    Pago = false,
                    Valor = Convert.ToDouble(tbValor.Text),
                    NomeCliente = tbDono.Text
                });
                MessageBox.Show("Pós consulta realizado com sucesso!");
            } catch
            {
                MessageBox.Show("Por favor preencha todos os campos!");
            }
            
            nomecliente = tbDono.Text;
            nomepet = tbPet.Text;
            RefreshDataGridView();
            LimparCampos();
            button1.Enabled = true;
        }

        private void LimparCampos()
        {
            tbResumo.Text = null;
            tbRemedios.Text = null;
            tbValor.Text = null;
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvConsulta.CurrentRow.Index;
            tbDono.Text = Convert.ToString(dgvConsulta["nomedono", cont].Value);
            tbPet.Text = Convert.ToString(dgvConsulta["nomepet", cont].Value);
            tbVet.Text = Convert.ToString(dgvConsulta["nomeveterinario", cont].Value);
            tbData.Text = Convert.ToString(dgvConsulta["data", cont].Value);

            codconsulta = Convert.ToInt16(dgvConsulta["ConsultaID", cont].Value);
            codpet = Convert.ToInt16(dgvConsulta["AnimalID", cont].Value);
            codveterinario = Convert.ToInt16(dgvConsulta["VeterinarioID", cont].Value);
            codcliente = Convert.ToInt16(dgvConsulta["ClienteID", cont].Value);

            btConfirmar.Enabled = true;
            btRetorno.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FormPosConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btRetorno_Click(object sender, EventArgs e)
        {
            FormMarcarConsulta formnovo = new FormMarcarConsulta(nomecliente, nomepet, codcliente, codpet);
            formnovo.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMarcarExame formnovo = new FormMarcarExame(codcliente, codpet, nomecliente, nomepet);
            formnovo.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
