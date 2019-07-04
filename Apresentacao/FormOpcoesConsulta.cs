using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormOpcoesConsulta : Form
    {
        public FormOpcoesConsulta()
        {
            InitializeComponent();
        }

        private void btMarcar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor selecione um cliente ou cadastre um novo e em seguida clique em Cadastrar Pet.");
            MessageBox.Show("\nEm seguida selecione um pet ou cadastre um novo e clique em Marcar Consulta.");
            FormCliente formcliente = new FormCliente();
            formcliente.Show();
        }

        private void btPos_Click(object sender, EventArgs e)
        {
            FormPosConsulta formnovo = new FormPosConsulta();
            formnovo.Show();
        }
    }
}
