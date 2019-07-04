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
    public partial class FormAgendaVet : Form
    {
        private int vetID;
        private ServicoConsulta servicoconsulta = new ServicoConsulta();

        public FormAgendaVet(int vetID)
        {
            InitializeComponent();
            this.vetID = vetID;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PreencheDGV(IQueryable<Consulta> consultas)
        {
            dgvConsultas.DataSource = (from consulta in consultas where consulta.VeterinarioID == vetID select consulta).ToList();

        }

        private void FormHistoricoVet_Load(object sender, EventArgs e)
        {
            List<Consulta> consultas = servicoconsulta.Buscar(X => X.VeterinarioID == vetID).ToList();
            dgvConsultas.DataSource = consultas;
            dgvConsultas.Columns["ClienteID"].Visible = false;
            dgvConsultas.Columns["AnimalID"].Visible = false;
            dgvConsultas.Columns["VeterinarioID"].Visible = false;
        }

        private void btConfirmaData_Click(object sender, EventArgs e)
        {
            var consultas = servicoconsulta.BuscarPorData(calendario.SelectionStart, calendario.SelectionEnd);
            PreencheDGV(consultas);
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            mkDataInicio.Text = Convert.ToString(calendario.SelectionStart);
            mkDataFim.Text = Convert.ToString(calendario.SelectionEnd);
            btConfirmaData.Enabled = true;
        }

        private void mkDataInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormAgendaVet_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormVeterinario formnew = new FormVeterinario();
            formnew.Show();
        }
    }
}
