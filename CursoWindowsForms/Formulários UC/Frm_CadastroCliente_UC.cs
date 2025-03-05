using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;

namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Grb_Codigo.Text = "Código do Cliente";
            Grb_DadosPessoais.Text = "Dados Pessoais";
            Grb_TemPai.Text = "";
            Grb_Endereco.Text = "Endereço";
            Grb_Outros.Text = "Outras informações";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Chk_TemPai.Text = "Pai desconhecido";
            Rb_Masculino.Text = "Masculino";
            Rb_Feminino.Text = "Feminino";
            Rb_Outro.Text = "Outro";
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit Cliente = new Cliente.Unit();
                Cliente.Id = Txt_Codigo.Text;
                Cliente.ValidaClasse();
                MessageBox.Show("Classe foi inicializada sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CANSA NAO IDIOTA??W");
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AI TOMA");
        }

        private void Apaga_toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PAM PAM PAM PAM, PAM");
        }

        private void Limpar_toolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ALURANTE");
        }
    }
}
