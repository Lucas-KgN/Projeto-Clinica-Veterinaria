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
    public partial class FormApresentacao : Form
    {
        public FormApresentacao()
        {
            InitializeComponent();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new FormCliente();
            formcliente.Show();
        }

        private void btVeterinario_Click(object sender, EventArgs e)
        {
            FormVeterinario formveterinario = new FormVeterinario();
            formveterinario.Show();
        }

        private void btPet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor selecione um cliente ou cadastre um novo e em seguida clique em Pet.");
            FormCliente formcliente = new FormCliente();
            formcliente.Show();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            FormOpcoesConsulta formopcoes = new FormOpcoesConsulta();
            formopcoes.Show();
        }

        private void btExame_Click(object sender, EventArgs e)
        {
            FormOpcaoExame formnew = new FormOpcaoExame();
            formnew.Show();
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {
            FormOpcaoCaixa formnew = new FormOpcaoCaixa();
            formnew.Show();
        }
    }
}
