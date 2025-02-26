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
    public partial class Frm_MouseEventos : Form
    {
        public Frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void Btn_MouseEventos_MouseEnter(object sender, EventArgs e)
        {
            Btn_MouseEventos.Text = "MOUSE ENTER";
        }

        private void Btn_MouseEventos_MouseLeave(object sender, EventArgs e)
        {
            Btn_MouseEventos.Text = "MOUSE LEAVE";
        }

        private void Btn_MouseEventos_MouseHover(object sender, EventArgs e)
        {
            Btn_MouseEventos.Text = "MOUSE HOVER";
        }

        private void Btn_MouseEventos_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_MouseEventos.Text = "MOUSE DOWN";
        }

        private void Btn_MouseEventos_MouseUp(object sender, MouseEventArgs e)
        {
            Btn_MouseEventos.Text = "MOUSE UP";
        }
    }
}
