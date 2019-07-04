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
    public partial class FormMarcarConsulta : Form
    {
        private ServicoVeterinario servicovet = new ServicoVeterinario();
        private ServicoConsulta servicoconsulta = new ServicoConsulta();
        private DateTime data;
        

        private string nomecliente { get; set; }
        private string nomepet { get; set; }
        private int codcliente { get; set; }
        private int codpet { get; set; }
        private int codvet { get; set; }
        
        public FormMarcarConsulta(string nomecliente, string nomepet, int codcliente, int codpet)
        {
            this.codcliente = codcliente;
            this.codpet = codpet;
            this.nomecliente = nomecliente;
            this.nomepet = nomepet;
            InitializeComponent();
            CompletaCampos();
            RefreshDataGridView();
        }

        public void CompletaCampos()
        {
            tbDono.Text = nomecliente;
            tbPet.Text = nomepet;
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {

        }

        private void cbVet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            int cont = dgvConsultaVets.CurrentRow.Index;
            tbVet.Text = Convert.ToString(dgvConsultaVets["nome", cont].Value);
            codvet = Convert.ToInt16(dgvConsultaVets["VeterinarioID", cont].Value);
            tbVet.Enabled = true;
            btMarcar.Enabled = true;
        }

        private void RefreshDataGridView()
        {
            dgvConsultaVets.DataSource = servicovet.ObterTodosInclude();
        }

        private void btMarcar_Click(object sender, EventArgs e)
        {
            servicoconsulta.Gravar(
                new Consulta()
                {
                    ClienteID = codcliente,
                    AnimalID = codpet,
                    VeterinarioID = codvet,
                    NomeVeterinario = tbVet.Text,
                    NomeDono = nomecliente,
                    NomePet = nomepet,
                    Data = data
                });
            RefreshDataGridView();
            LimparCampos();
            MessageBox.Show("Consulta cadastrada com sucesso!");
        }

        private void LimparCampos()
        {
            tbDono.Text = null;
            tbData.Text = null;
            tbPet.Text = null;
            tbVet.Text = null;
        }

        private void mcData_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btData_Click(object sender, EventArgs e)
        {
            var data = mcData.SelectionStart.Day.ToString() + "/" + mcData.SelectionStart.Month.ToString() + "/" + mcData.SelectionStart.Year.ToString();
            tbData.Text = data;
            this.data = Convert.ToDateTime(data);
            tbData.Enabled = true;
        }
    }
}
