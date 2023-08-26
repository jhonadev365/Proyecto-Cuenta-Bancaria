
namespace FormConsumer
{
    partial class CrearCuentaForm
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
            this.CumpleaniosTbp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTb = new System.Windows.Forms.TextBox();
            this.CelularMtb = new System.Windows.Forms.MaskedTextBox();
            this.DireccionRtb = new System.Windows.Forms.RichTextBox();
            this.txtdireccion = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.CelularCb = new System.Windows.Forms.CheckBox();
            this.DireccionCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CumpleaniosTbp
            // 
            this.CumpleaniosTbp.Location = new System.Drawing.Point(171, 55);
            this.CumpleaniosTbp.Name = "CumpleaniosTbp";
            this.CumpleaniosTbp.Size = new System.Drawing.Size(200, 20);
            this.CumpleaniosTbp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Nacimiento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Celular: ";
            // 
            // NombreTb
            // 
            this.NombreTb.Location = new System.Drawing.Point(171, 29);
            this.NombreTb.Name = "NombreTb";
            this.NombreTb.Size = new System.Drawing.Size(200, 20);
            this.NombreTb.TabIndex = 0;
            // 
            // CelularMtb
            // 
            this.CelularMtb.Location = new System.Drawing.Point(171, 81);
            this.CelularMtb.Mask = "000-00-000";
            this.CelularMtb.Name = "CelularMtb";
            this.CelularMtb.Size = new System.Drawing.Size(200, 20);
            this.CelularMtb.TabIndex = 5;
            this.CelularMtb.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // DireccionRtb
            // 
            this.DireccionRtb.Location = new System.Drawing.Point(171, 107);
            this.DireccionRtb.Name = "DireccionRtb";
            this.DireccionRtb.Size = new System.Drawing.Size(200, 94);
            this.DireccionRtb.TabIndex = 6;
            this.DireccionRtb.Text = "";
            // 
            // txtdireccion
            // 
            this.txtdireccion.AutoSize = true;
            this.txtdireccion.Location = new System.Drawing.Point(31, 110);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(58, 13);
            this.txtdireccion.TabIndex = 7;
            this.txtdireccion.Text = "Direccion: ";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(171, 223);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(114, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "CREAR CUENTA";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // CelularCb
            // 
            this.CelularCb.AutoSize = true;
            this.CelularCb.Location = new System.Drawing.Point(378, 84);
            this.CelularCb.Name = "CelularCb";
            this.CelularCb.Size = new System.Drawing.Size(15, 14);
            this.CelularCb.TabIndex = 9;
            this.CelularCb.UseVisualStyleBackColor = true;
            this.CelularCb.CheckedChanged += new System.EventHandler(this.CelularCheckbox_CheckedChanged);
            // 
            // DireccionCb
            // 
            this.DireccionCb.AutoSize = true;
            this.DireccionCb.Location = new System.Drawing.Point(378, 107);
            this.DireccionCb.Name = "DireccionCb";
            this.DireccionCb.Size = new System.Drawing.Size(15, 14);
            this.DireccionCb.TabIndex = 10;
            this.DireccionCb.UseVisualStyleBackColor = true;
            this.DireccionCb.CheckedChanged += new System.EventHandler(this.DireccionCheckBox_CheckedChanged);
            // 
            // CrearCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.DireccionCb);
            this.Controls.Add(this.CelularCb);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.DireccionRtb);
            this.Controls.Add(this.CelularMtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CumpleaniosTbp);
            this.Controls.Add(this.NombreTb);
            this.Name = "CrearCuentaForm";
            this.Text = "Panel de creacion de cuenta";
            this.Load += new System.EventHandler(this.CrearCuentaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker CumpleaniosTbp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTb;
        private System.Windows.Forms.MaskedTextBox CelularMtb;
        private System.Windows.Forms.RichTextBox DireccionRtb;
        private System.Windows.Forms.Label txtdireccion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.CheckBox CelularCb;
        private System.Windows.Forms.CheckBox DireccionCb;
    }
}