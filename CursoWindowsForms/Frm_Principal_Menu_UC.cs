using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int controleHelloWorld = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey DK = new Frm_DemonstracaoKey();
            DK.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controleHelloWorld += 1;
            Frm_HelloWorld_UC HW = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            TB.Name = "Hello World" + controleHelloWorld;
            TB.Text = "Hello World" + controleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(HW);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara MCR = new Frm_Mascara();
            MCR.ShowDialog();

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF CPF = new Frm_ValidaCPF();
            CPF.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 CPF2 = new Frm_ValidaCPF2();
            CPF2.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha SNH = new Frm_ValidaSenha();
            SNH.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
                
        }
    }
}
