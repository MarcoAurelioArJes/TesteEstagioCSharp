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
    public partial class TelaListagem : Form {
        private string chassi;

        Carros carros = new Carros();

        public TelaListagem() {
            InitializeComponent();

            listViewCarros.View = View.Details;
            listViewCarros.LabelEdit = true;
            listViewCarros.AllowColumnReorder = true;
            listViewCarros.FullRowSelect = true;
            listViewCarros.GridLines = true;

            listViewCarros.Columns.Add("Chassi", 150, HorizontalAlignment.Left);
            listViewCarros.Columns.Add("Marca", 150, HorizontalAlignment.Left);
            listViewCarros.Columns.Add("Modelo", 150, HorizontalAlignment.Left);
            listViewCarros.Columns.Add("Placa", 150, HorizontalAlignment.Left);
            listViewCarros.Columns.Add("Ano", 75, HorizontalAlignment.Left);

            ListarCarros();
        }

        public void ListarCarros() {
            listViewCarros.Items.Clear();
            foreach (Carros info in carros.Listar())
            {
                string[] linha = {
                    info.Chassi,
                    info.Marca,
                    info.Modelo,
                    info.Placa,
                    info.Ano
                };
                listViewCarros.Items.Add(new ListViewItem(linha));
            }
        }

        private void ButtonBusca_Click(object sender, EventArgs e) {
            listViewCarros.Items.Clear();
            foreach (Carros info in carros.ListarBusca(txtBusca.Text))
            {
                string[] linha = {
                    info.Chassi,
                    info.Marca,
                    info.Modelo,
                    info.Placa,
                    info.Ano
                };
                listViewCarros.Items.Add(new ListViewItem(linha));
            }
        }

        private void ListViewCarros_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            ListView.SelectedListViewItemCollection itemSelecionado = listViewCarros.SelectedItems;

            foreach(ListViewItem item in itemSelecionado) {
                chassi = item.SubItems[0].Text;
            }
        }

        private void Excluir_Click(object sender, EventArgs e) {
            try {
                carros.Excluir(chassi);
                MessageBox.Show("Carro excluído com sucesso!!!");
                ListarCarros();
            } catch (Exception err) {
                MessageBox.Show("Erro: " + err.Message);
            }
        }

        private void Editar_Click(object sender, EventArgs e) {
            TelaDetalhes telaDetalhes = new TelaDetalhes();

            ListView.SelectedListViewItemCollection itemSelecionado = listViewCarros.SelectedItems;

            foreach (ListViewItem item in itemSelecionado)
            {
                telaDetalhes.PegaDetalhesDados(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
            }
            telaDetalhes.Show();
        }

        private void Carregar_Click(object sender, EventArgs e) {
            ListarCarros();
        }

        private void TelaListagem_Activated(object sender, EventArgs e) {
            ListarCarros();
        }
    }
}
