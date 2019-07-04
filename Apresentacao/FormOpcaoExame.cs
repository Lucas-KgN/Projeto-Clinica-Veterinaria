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
    public partial class FormOpcaoExame : Form
    {
        public FormOpcaoExame()
        {
            InitializeComponent();
        }

        private void btInformacoes_Click(object sender, EventArgs e)
        {
            FormCriarExame formnew = new FormCriarExame();
            formnew.Show();
        }

        private void btMarcar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para marcar um exame, primeiro se faz necessário a validação do pós consulta pelo veterinário!");
            MessageBox.Show("Após isso, na aba de pós consulta clique em Marcar Exame");
            FormPosConsulta formnew = new FormPosConsulta();
            formnew.Show();

        }

        private void FormOpcaoExame_Load(object sender, EventArgs e)
        {

        }
    }
}
