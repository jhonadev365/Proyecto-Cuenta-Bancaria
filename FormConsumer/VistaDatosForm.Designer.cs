
namespace FormConsumer
{
    partial class VistaDatosForm
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
            this.ListaDatoTransacciones = new System.Windows.Forms.ListBox();
            this.EntradaDeposito = new System.Windows.Forms.TextBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.EntradaRetiro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTipoTransaccion = new FormConsumer.EntradaPersonalizadaControl();
            this.panelMonto = new FormConsumer.EntradaPersonalizadaControl();
            this.panelFecha = new FormConsumer.EntradaPersonalizadaControl();
            this.panelLugar = new FormConsumer.EntradaPersonalizadaControl();
            this.panelMontoActual = new FormConsumer.EntradaPersonalizadaControl();
            this.panelNombre = new FormConsumer.EntradaPersonalizadaControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaDatoTransacciones
            // 
            this.ListaDatoTransacciones.FormattingEnabled = true;
            this.ListaDatoTransacciones.Location = new System.Drawing.Point(12, 12);
            this.ListaDatoTransacciones.Name = "ListaDatoTransacciones";
            this.ListaDatoTransacciones.Size = new System.Drawing.Size(216, 277);
            this.ListaDatoTransacciones.TabIndex = 0;
            this.ListaDatoTransacciones.SelectedIndexChanged += new System.EventHandler(this.ListaDatoTransacciones_SelectedIndexChanged);
            // 
            // EntradaDeposito
            // 
            this.EntradaDeposito.Location = new System.Drawing.Point(12, 295);
            this.EntradaDeposito.Name = "EntradaDeposito";
            this.EntradaDeposito.Size = new System.Drawing.Size(100, 20);
            this.EntradaDeposito.TabIndex = 6;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(36, 322);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 7;
            this.btnDeposito.Text = "DEPOSITO";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(152, 321);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 8;
            this.btnRetiro.Text = "RETIRO";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // EntradaRetiro
            // 
            this.EntradaRetiro.Location = new System.Drawing.Point(126, 295);
            this.EntradaRetiro.Name = "EntradaRetiro";
            this.EntradaRetiro.Size = new System.Drawing.Size(100, 20);
            this.EntradaRetiro.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelTipoTransaccion);
            this.groupBox1.Controls.Add(this.panelMonto);
            this.groupBox1.Controls.Add(this.panelFecha);
            this.groupBox1.Controls.Add(this.panelLugar);
            this.groupBox1.Location = new System.Drawing.Point(275, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 183);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS TRANSACCION";
            // 
            // panelTipoTransaccion
            // 
            this.panelTipoTransaccion.Location = new System.Drawing.Point(6, 19);
            this.panelTipoTransaccion.Name = "panelTipoTransaccion";
            this.panelTipoTransaccion.Size = new System.Drawing.Size(222, 33);
            this.panelTipoTransaccion.TabIndex = 2;
            this.panelTipoTransaccion.ValorEntrada = "";
            this.panelTipoTransaccion.ValorEtiqueta = "Tipo transaccion:";
            // 
            // panelMonto
            // 
            this.panelMonto.Location = new System.Drawing.Point(6, 58);
            this.panelMonto.Name = "panelMonto";
            this.panelMonto.Size = new System.Drawing.Size(222, 33);
            this.panelMonto.TabIndex = 3;
            this.panelMonto.ValorEntrada = "";
            this.panelMonto.ValorEtiqueta = "Monto:";
            // 
            // panelFecha
            // 
            this.panelFecha.Location = new System.Drawing.Point(6, 97);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(222, 33);
            this.panelFecha.TabIndex = 4;
            this.panelFecha.ValorEntrada = "";
            this.panelFecha.ValorEtiqueta = "Fecha:";
            // 
            // panelLugar
            // 
            this.panelLugar.Location = new System.Drawing.Point(6, 136);
            this.panelLugar.Name = "panelLugar";
            this.panelLugar.Size = new System.Drawing.Size(222, 33);
            this.panelLugar.TabIndex = 5;
            this.panelLugar.ValorEntrada = "";
            this.panelLugar.ValorEtiqueta = "Lugar:";
            // 
            // panelMontoActual
            // 
            this.panelMontoActual.Location = new System.Drawing.Point(275, 78);
            this.panelMontoActual.Name = "panelMontoActual";
            this.panelMontoActual.Size = new System.Drawing.Size(222, 33);
            this.panelMontoActual.TabIndex = 10;
            this.panelMontoActual.ValorEntrada = "";
            this.panelMontoActual.ValorEtiqueta = "Monto Actual:";
            // 
            // panelNombre
            // 
            this.panelNombre.Location = new System.Drawing.Point(275, 39);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(222, 33);
            this.panelNombre.TabIndex = 1;
            this.panelNombre.ValorEntrada = "Ejemplo";
            this.panelNombre.ValorEtiqueta = "Nombre:";
            // 
            // VistaDatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMontoActual);
            this.Controls.Add(this.EntradaRetiro);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.EntradaDeposito);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.ListaDatoTransacciones);
            this.Name = "VistaDatosForm";
            this.Text = "VistaDatosForm";
            this.Load += new System.EventHandler(this.VistaDatosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaDatoTransacciones;
        private EntradaPersonalizadaControl panelNombre;
        private EntradaPersonalizadaControl panelTipoTransaccion;
        private EntradaPersonalizadaControl panelMonto;
        private EntradaPersonalizadaControl panelFecha;
        private EntradaPersonalizadaControl panelLugar;
        private System.Windows.Forms.TextBox EntradaDeposito;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.TextBox EntradaRetiro;
        private EntradaPersonalizadaControl panelMontoActual;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}