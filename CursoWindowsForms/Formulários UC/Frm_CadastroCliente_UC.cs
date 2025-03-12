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
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca;
using CursoWindowsFormsBiblioteca.Classes.Databases;
using CursoWindowsForms.Dialog_Box;

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


        private void LimparFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_Bairro.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            Txt_Cidade.Text = "";
            Cb_Estados.SelectedIndex = -1;
            Chk_TemPai.Checked = false;
            Rb_Masculino.Checked = false; Rb_Feminino.Checked = false; Rb_Outro.Checked = false;
            Txt_Logradouro.Text = null;
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Profissao.Text = "";
            Txt_RendaFamiliar.Text = null;
            Txt_Telefone.Text = null;           
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
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.Id = Txt_Codigo.Text;
                C.ValidaClasse();
                C.ValidaComplemento();
                string clienteJson = Cliente.SerializedClassUnit(C);               

                Db_Fichario F = new Db_Fichario("C:\\Users\\conap\\OneDrive\\Documentos\\Estudo-Eric\\CursoWindowsForms\\CursoWindowsForm2\\Fichario");
                if (F.status)
                {
                    F.incluir(C.Id, clienteJson);
                    if (F.status)
                    {
                        MessageBox.Show("OK: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if(Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Db_Fichario F = new Db_Fichario("C:\\Users\\conap\\OneDrive\\Documentos\\Estudo-Eric\\CursoWindowsForms\\CursoWindowsForm2\\Fichario");
                if (F.status)
                {
                    string clienteJson = F.Buscar(Txt_Codigo.Text);
                    Cliente.Unit c = new Cliente.Unit();
                    c = Cliente.DeSerializedClassUnit(clienteJson);
                    EscreveFormulario(c);
                }
                else
                {
                    MessageBox.Show("Caminho do banco incorreto", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AI TOMA");
        }

        private void Apaga_toolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Db_Fichario F = new Db_Fichario("C:\\Users\\conap\\OneDrive\\Documentos\\Estudo-Eric\\CursoWindowsForms\\CursoWindowsForm2\\Fichario");
                if (F.status)
                {

                    string clienteJson = F.Buscar(Txt_Codigo.Text);
                    Cliente.Unit c = new Cliente.Unit();
                    c = Cliente.DeSerializedClassUnit(clienteJson);
                    EscreveFormulario(c);

                    Frm_Questao Db = new Frm_Questao("ExcluirBarra", "Você quer excluir o cliente?");
                    Db.ShowDialog();
                    if (Db.DialogResult == DialogResult.Yes)
                    {
                        if (F.status)
                        {
                            MessageBox.Show("OK: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                        else
                        {
                            MessageBox.Show("ERR: " + F.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        F.Apagar(Txt_Codigo.Text);
                    }

                    
                }
                else
                {
                    MessageBox.Show("Caminho do banco incorreto", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Limpar_toolStripButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Id = Txt_Codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
               C.NaoTemPai = true;
            }
            else
            {
               C.NaoTemPai = false;
            }
            if(Rb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rb_Outro.Checked)
            {
                C.Genero = 2;
            }
            C.Cpf = Txt_CPF.Text;

            C.Cep = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;

            if (Cb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cb_Estados.Items[Cb_Estados.SelectedIndex].ToString();
            }
            C.Telefone = Txt_Telefone.Text;
            C.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric (Txt_RendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
                if (vRenda < 0) 
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }
            
            

            return C;
        }
        void EscreveFormulario(Cliente.Unit C)
        {            
            Txt_Codigo.Text = C.Id;
            Txt_NomeCliente.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;
            Txt_NomePai.Text = C.NomePai;
            if (C.NaoTemPai == true)
            {
                Chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                C.NaoTemPai = false;
                Txt_NomePai.Text = C.NomePai;
            }
            if (C.Genero == 0)
            {
                Rb_Masculino.Checked = true;
            }
            if (C.Genero == 1)
            {
                Rb_Feminino.Checked = true;
            }
            if (C.Genero == 2)
            {
                Rb_Outro.Checked = true;
            }

            Txt_CPF.Text = C.Cpf;
            Txt_CEP.Text = C.Cep;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Complemento.Text = C.Complemento;
            Txt_Cidade.Text = C.Cidade;
            Txt_Bairro.Text = C.Bairro;
            Txt_Telefone.Text = C.Telefone;
            Txt_Profissao.Text = C.Profissao;



            if (C.Estado == "")
            {
                Cb_Estados.SelectedIndex = -1;
            }
            else
            {

                for (int i = 0; i<= Cb_Estados.Items.Count -1; i++)
                {
                    if (C.Estado == Cb_Estados.Items[i].ToString())
                    {
                        Cb_Estados.SelectedIndex = i;
                    }
                }                
            }

            Txt_RendaFamiliar.Text = C.RendaFamiliar.ToString();

            
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializedClassUnit(vJson);
                        Txt_Logradouro.Text = CEP.Logradouro;
                        Txt_Bairro.Text = CEP.Bairro;
                        Txt_Cidade.Text = CEP.Localidade;

                        Cb_Estados.SelectedIndex = -1;
                        for (int i =0; i <= Cb_Estados.Items.Count -1; i++)
                        {
                            var vPos = Strings.InStr(Cb_Estados.Items[i].ToString(), $"({CEP.Uf})");
                            if (vPos > 0)
                            {
                                Cb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }            
        }
    }
}
