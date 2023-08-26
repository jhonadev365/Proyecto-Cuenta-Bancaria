using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksClassLibrary;

namespace FormConsumer
{
    public partial class VistaDatosForm : Form
    {
        private Account MyAccount;
        
        BindingList<transacciones> listaDinamica;

        private VistaDatosForm() { }
        public VistaDatosForm(Account rAccount)
        {
            InitializeComponent();
            MyAccount = rAccount;
            listaDinamica = new BindingList<transacciones>(MyAccount.ListaDeTransacciones);
            ListaDatoTransacciones.DataSource = listaDinamica;
            ListaDatoTransacciones.DisplayMember = "DetalleResumen"; //ES UNA PROPIEDAD QUE TOMA DE LA CLASE TRANSACCIONES
            panelNombre.ValorEntrada = MyAccount.nombreCliente;
            panelMontoActual.ValorEntrada = MyAccount.SaldoActual.ToString();

        }

        private void VistaDatosForm_Load(object sender, EventArgs e)
        {

        }

        private void ListaDatoTransacciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexItem = ListaDatoTransacciones.SelectedIndex;
            transacciones transaccionSeleccionada = MyAccount.ListaDeTransacciones[indexItem];
            panelTipoTransaccion.ValorEntrada = transaccionSeleccionada.TipoDeTransaccionString;
            panelFecha.ValorEntrada = transaccionSeleccionada.FechaString;
            panelMonto.ValorEntrada = transaccionSeleccionada.monto.ToString();
            panelLugar.ValorEntrada = transaccionSeleccionada.LugarTransaccion;

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(EntradaDeposito.Text);
            if (!MyAccount.AgregarDinero(valorDeposito))
            {
                MessageBox.Show("La solicitud de Deposito no es valida.");
                return;
            }
            panelMontoActual.ValorEntrada = MyAccount.SaldoActual.ToString();
            listaDinamica.ResetBindings();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            double valorRetiro = Convert.ToDouble(EntradaRetiro.Text);
            if (!MyAccount.RetirarDinero(valorRetiro))
            {
                MessageBox.Show("La solicitud de Retiro no es valida.");
                return;
            }
            panelMontoActual.ValorEntrada = MyAccount.SaldoActual.ToString();
            listaDinamica.ResetBindings();

        }
    }
}
