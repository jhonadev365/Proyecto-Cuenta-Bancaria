using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConsumer
{
    public partial class EntradaPersonalizadaControl : UserControl
    {
        public string ValorEtiqueta
        {
            get
            {
                return EtiquetaModelo.Text;
            }
            set
            {
                EtiquetaModelo.Text = value;
            }
        }

        public string ValorEntrada
        {
            get
            {
                return EntradaModelo.Text;
            }
            set
            {
                EntradaModelo.Text = value;
            }
        }


        public EntradaPersonalizadaControl()
        {
            InitializeComponent();
        }
    }
}
