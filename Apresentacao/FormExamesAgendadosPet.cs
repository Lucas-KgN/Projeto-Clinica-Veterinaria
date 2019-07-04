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
    public partial class FormExamesAgendadosPet : Form
    {
        private ServicoProcedimento servicoprocedimento = new ServicoProcedimento();
        private int codpet;

        public FormExamesAgendadosPet(int codpet)
        {
            InitializeComponent();
            this.codpet = codpet;
        }

        private void FormExamesAgendadosPet_Load(object sender, EventArgs e)
        {
            List<Procedimento> exames = servicoprocedimento.Buscar(X => X.AnimalID == codpet).ToList();
            dgvExames.DataSource = exames;

        }
    }
}
