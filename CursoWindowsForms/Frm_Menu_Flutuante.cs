﻿using System;
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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Right)
            {
                               
                //MessageBox.Show($"Cliquei com o botão da direita do mouse! A posição relativa foi: {Px.ToString()},{Py.ToString()}");

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");


                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X,e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opçao do menu 001");
            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Eu nao aguento mais");
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;
                Image Myimage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = Myimage;

                return vToolTip;               
            }
        }
    }
}
