using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormOpcaoCaixa : Form
    {
        public FormOpcaoCaixa()
        {
            InitializeComponent();
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            FormPag formnew = new FormPag();
            formnew.Show();
        }

        private void btInformacoes_Click(object sender, EventArgs e)
        {
            FormCaixa formnew = new FormCaixa();
            formnew.Show();
        }
    }
}
