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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemontracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey DK = new Frm_DemonstracaoKey();
            DK.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld HW = new Frm_HelloWorld();
            HW.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara MCR = new Frm_Mascara();
            MCR.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF CPF = new Frm_ValidaCPF();
            CPF.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 CPF2 = new Frm_ValidaCPF2();
            CPF2.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha SNH = new Frm_ValidaSenha();
            SNH.ShowDialog();
        }
    }
}
