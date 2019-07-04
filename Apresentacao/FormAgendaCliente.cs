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
    public partial class FormAgendaCliente : Form
    {
        private int codcliente;
        private ServicoConsulta servicoconsulta = new ServicoConsulta();

        public FormAgendaCliente(int codcliente)
        {
            InitializeComponent();
            this.codcliente = codcliente;

        }

        private void FormHistoricoCliente_Load(object sender, EventArgs e)
        {
            List<Consulta> consultas = servicoconsulta.Buscar(X => X.ClienteID == codcliente).ToList();
            dgvConsultasCliente.DataSource = consultas;
            dgvConsultasCliente.Columns["ClienteID"].Visible = false;
            dgvConsultasCliente.Columns["AnimalID"].Visible = false;
            dgvConsultasCliente.Columns["VeterinarioID"].Visible = false;
        }

        private void PreencheDGV(IQueryable<Consulta> consultas)
        {
            dgvConsultasCliente.DataSource = (from consulta in consultas where consulta.ClienteID == codcliente select consulta).ToList();
            dgvConsultasCliente.Columns["ClienteID"].Visible = false;
            dgvConsultasCliente.Columns["AnimalID"].Visible = false;
            dgvConsultasCliente.Columns["VeterinarioID"].Visible = false;
        }

        private void btConfirmaData_Click(object sender, EventArgs e)
        {
            var consultas = servicoconsulta.BuscarPorData(calendario.SelectionStart, calendario.SelectionEnd);
            PreencheDGV(consultas);
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            mkDataInicio.Text = Convert.ToString(calendario.SelectionStart);
            mkDataFim.Text = Convert.ToString(calendario.SelectionEnd);
            btConfirmaData.Enabled = true;
        }

        private void FormAgendaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCliente formnew = new FormCliente();
            formnew.Show();
        }
    }
}
