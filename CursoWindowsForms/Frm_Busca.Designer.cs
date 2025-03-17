namespace CursoWindowsForms
{
    partial class Frm_Busca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.Tsp_Principal = new System.Windows.Forms.ToolStrip();
            this.SalvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Lst_busca = new System.Windows.Forms.ListBox();
            this.ExcluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Tsp_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tsp_Principal
            // 
            this.Tsp_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalvarToolStripButton,
            this.ExcluirToolStripButton});
            this.Tsp_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tsp_Principal.Name = "Tsp_Principal";
            this.Tsp_Principal.Size = new System.Drawing.Size(344, 25);
            this.Tsp_Principal.TabIndex = 33;
            this.Tsp_Principal.Text = "toolStrip1";
            // 
            // SalvarToolStripButton
            // 
            this.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SalvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalvarToolStripButton.Image")));
            this.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalvarToolStripButton.Name = "SalvarToolStripButton";
            this.SalvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SalvarToolStripButton.Text = "&Salvar";
            this.SalvarToolStripButton.Click += new System.EventHandler(this.SalvarToolStripButton_Click);
            // 
            // Lst_busca
            // 
            this.Lst_busca.FormattingEnabled = true;
            this.Lst_busca.Location = new System.Drawing.Point(12, 32);
            this.Lst_busca.Name = "Lst_busca";
            this.Lst_busca.Size = new System.Drawing.Size(320, 277);
            this.Lst_busca.TabIndex = 34;
            // 
            // ExcluirToolStripButton
            // 
            this.ExcluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcluirToolStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            this.ExcluirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExcluirToolStripButton.Text = "toolStripButton1";
            this.ExcluirToolStripButton.Click += new System.EventHandler(this.ExcluirToolStripButton_Click);
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.Lst_busca);
            this.Controls.Add(this.Tsp_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Busca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Busca";
            this.Tsp_Principal.ResumeLayout(false);
            this.Tsp_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tsp_Principal;
        private System.Windows.Forms.ToolStripButton SalvarToolStripButton;
        private System.Windows.Forms.ListBox Lst_busca;
        private System.Windows.Forms.ToolStripButton ExcluirToolStripButton;
    }
}