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
    public partial class FormProntuarioPet : Form
    {
        private ServicoConsulta servicoconsulta = new ServicoConsulta();
        private int animalid;

        public FormProntuarioPet(int animalid)
        {
            InitializeComponent();
            this.animalid = animalid;
        }

        private void FormHistoricoPet_Load(object sender, EventArgs e)
        {
            List<Consulta> consultas = servicoconsulta.Buscar(X => X.AnimalID == animalid).ToList();
            dgvConsultas.DataSource = consultas;
            dgvConsultas.Columns["ClienteID"].Visible = false;
            dgvConsultas.Columns["AnimalID"].Visible = false;
            dgvConsultas.Columns["VeterinarioID"].Visible = false;
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cont = dgvConsultas.CurrentRow.Index;
            lbDono.Text = Convert.ToString(dgvConsultas["nomedono", cont].Value);
            lbPet.Text = Convert.ToString(dgvConsultas["nomepet", cont].Value);
            lbVet.Text = Convert.ToString(dgvConsultas["nomeveterinario", cont].Value);
            mkData.Text = Convert.ToString(dgvConsultas["data", cont].Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
