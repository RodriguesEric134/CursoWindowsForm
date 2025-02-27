namespace CursoWindowsForms
{
    partial class Frm_MouseCaptura
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
            this.Btn_Captura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Captura
            // 
            this.Btn_Captura.Location = new System.Drawing.Point(122, 77);
            this.Btn_Captura.Name = "Btn_Captura";
            this.Btn_Captura.Size = new System.Drawing.Size(203, 102);
            this.Btn_Captura.TabIndex = 0;
            this.Btn_Captura.Text = "button1";
            this.Btn_Captura.UseVisualStyleBackColor = true;
            this.Btn_Captura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Captura_MouseDown);
            // 
            // Frm_MouseCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.Btn_Captura);
            this.Name = "Frm_MouseCaptura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MouseCaptura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Captura;
    }
}