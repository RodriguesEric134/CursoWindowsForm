namespace CursoWindowsForms
{
    partial class Frm_MouseEventos
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
            this.Btn_MouseEventos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MouseEventos
            // 
            this.Btn_MouseEventos.Location = new System.Drawing.Point(80, 65);
            this.Btn_MouseEventos.Name = "Btn_MouseEventos";
            this.Btn_MouseEventos.Size = new System.Drawing.Size(206, 139);
            this.Btn_MouseEventos.TabIndex = 0;
            this.Btn_MouseEventos.UseVisualStyleBackColor = true;
            this.Btn_MouseEventos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseEventos_MouseDown);
            this.Btn_MouseEventos.MouseEnter += new System.EventHandler(this.Btn_MouseEventos_MouseEnter);
            this.Btn_MouseEventos.MouseLeave += new System.EventHandler(this.Btn_MouseEventos_MouseLeave);
            this.Btn_MouseEventos.MouseHover += new System.EventHandler(this.Btn_MouseEventos_MouseHover);
            this.Btn_MouseEventos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseEventos_MouseUp);
            // 
            // Frm_MouseEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.Btn_MouseEventos);
            this.Name = "Frm_MouseEventos";
            this.Text = "Frm_MouseEventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_MouseEventos;
    }
}