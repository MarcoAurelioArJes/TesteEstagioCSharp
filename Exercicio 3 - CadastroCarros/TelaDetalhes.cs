using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCarros
{
    public partial class TelaDetalhes : Form
    {
        Carros carro = new Carros();
        public TelaDetalhes()
        {
            InitializeComponent();
        }

        public void PegaDetalhesDados(string chassi, string marca, string modelo, string placa, string ano) {
            txtChassiDetalhes.Text = chassi;
            txtMarcaDetalhes.Text = marca;
            txtModeloDetalhes.Text = modelo;
            txtPlacaDetalhes.Text = placa;
            txtAnoDetalhes.Text = ano;
        }

        private void Atualizar_Click(object sender, EventArgs e) {
            try {
                carro.Atualizar(txtChassiDetalhes.Text, txtModeloDetalhes.Text,
                            txtPlacaDetalhes.Text, txtMarcaDetalhes.Text, txtAnoDetalhes.Text);
                MessageBox.Show("Informações atualizadas com sucesso!!!");
                this.Close();
            } catch (Exception err) {
                MessageBox.Show("Erro: " + err.Message);
            }
        }
    }
}
