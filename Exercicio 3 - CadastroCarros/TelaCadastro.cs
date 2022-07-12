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
    public partial class TelaCadastro : Form {

        Carros carros = new Carros();

        public TelaCadastro() {
            InitializeComponent();
        }

        private void InserirDados(object sender, EventArgs e) {
            try {
                carros.Modelo = txtModelo.Text;
                carros.Placa = txtPlaca.Text;
                carros.Ano = txtAno.Text;
                carros.Marca = txtMarca.Text;
                carros.Chassi = txtChassi.Text;

                carros.Insere(carros);
                LimparCampos();

                MessageBox.Show("Carro cadastrado com sucesso!!!");
            } catch (Exception err) {
                MessageBox.Show("Erro: " + err.Message);
            }
        }

        private void LimparCampos() {
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            txtMarca.Text = "";
            txtChassi.Text = "";
        }
    }
}
