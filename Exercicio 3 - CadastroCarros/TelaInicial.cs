using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CadastroCarros
{
    public partial class TelaInicial : Form
    {
        TelaCadastro telaCad = new TelaCadastro();
        TelaListagem telaList = new TelaListagem();

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void telaCadastro(object sender, EventArgs e) {
            telaList.Hide();
            telaCad.MdiParent = this;
            telaCad.WindowState = FormWindowState.Maximized;
            telaCad.Show();
        }

        private void telaListagem(object sender, EventArgs e) {
            telaCad.Hide();
            telaList.MdiParent = this;
            telaList.WindowState = FormWindowState.Maximized;
            telaList.Show();
        }
    }
}
