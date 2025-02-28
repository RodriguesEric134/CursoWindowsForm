using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.ExemplosDIalogBox
{
    public partial class Frm_Login : Form
    {
        public string senha;
        public string login;

        public Frm_Login()
        {
            InitializeComponent();
            this.AcceptButton = Btn_OK;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            senha = Txt_Senha.Text;
            login = Txt_Login.Text;

            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MessageBox.Show("FODASE AMIGAO, NAO SEI FAZER ISSO AINDA KKKKKKKKKKKK", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
