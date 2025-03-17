using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CursoWindowsForms
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect { get; set; }
        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";

            PreencherLista();


            Tsp_Principal.Items[0].ToolTipText = "Salvar a seleção";

        }
        private void PreencherLista()
        {
            Lst_busca.Items.Clear();
            for (int i = 0; i < _ListaBusca.Count; i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];
                Lst_busca.Items.Add(X); // Apenas adicione o objeto ItemBox
            }
        }

        private void SalvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (Lst_busca.SelectedIndex != -1) // Verifica se um item está selecionado
            {
                DialogResult = DialogResult.OK;
                ItemBox ItemSelecionado = (ItemBox)Lst_busca.Items[Lst_busca.SelectedIndex];
                idSelect = ItemSelecionado.id;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item da lista."); // Mensagem para o usuário
            }
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}
