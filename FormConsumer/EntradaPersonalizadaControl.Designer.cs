
namespace FormConsumer
{
    partial class EntradaPersonalizadaControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.EntradaModelo = new System.Windows.Forms.TextBox();
            this.EtiquetaModelo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EntradaModelo);
            this.panel1.Controls.Add(this.EtiquetaModelo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 33);
            this.panel1.TabIndex = 4;
            // 
            // EntradaModelo
            // 
            this.EntradaModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntradaModelo.Location = new System.Drawing.Point(115, 3);
            this.EntradaModelo.Name = "EntradaModelo";
            this.EntradaModelo.Size = new System.Drawing.Size(100, 20);
            this.EntradaModelo.TabIndex = 2;
            // 
            // EtiquetaModelo
            // 
            this.EtiquetaModelo.AutoSize = true;
            this.EtiquetaModelo.Location = new System.Drawing.Point(3, 6);
            this.EtiquetaModelo.Name = "EtiquetaModelo";
            this.EtiquetaModelo.Size = new System.Drawing.Size(35, 13);
            this.EtiquetaModelo.TabIndex = 1;
            this.EtiquetaModelo.Text = "label1";
            // 
            // EntradaPersonalizadaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EntradaPersonalizadaControl";
            this.Size = new System.Drawing.Size(222, 33);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EntradaModelo;
        private System.Windows.Forms.Label EtiquetaModelo;
    }
}
