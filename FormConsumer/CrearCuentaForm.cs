using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConsumer
{
    public partial class CrearCuentaForm : Form
    {
        private string CampoCelular
        {
            get
            {
                if (CelularMtb.Enabled)
                {
                    return CelularMtb.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        private string CampoDireccion
        {
            get
            {
                if (DireccionRtb.Enabled)
                {
                    return DireccionRtb.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        public CrearCuentaForm()
        {
            InitializeComponent();
        }

        private void CrearCuentaForm_Load(object sender, EventArgs e)
        {
            CelularCb.Checked = true;
            DireccionCb.Checked = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            string nombreus = NombreTb.Text;
            DateTime fechaus = CumpleaniosTbp.Value;

            if (!Validador_nombre(nombreus))
            {
                MessageBox.Show("Nombre invalido.");
                return;
            }
            else if (!Validador_fecha(fechaus))
            {
                MessageBox.Show("Fecha invalida debe ser mayor de 18 años.");
                return;
            }

            string celularus = CampoCelular;
            string direccionus = CampoDireccion;

            //Account nueva = new Account(nombreus, fechaus, celularus, direccionus);

            ValidacionCuenta nuevaValidacionDeCuenta = new ValidacionCuenta(-1, nombreus, fechaus, celularus, direccionus);
            GuardadoDeCuenta nuevaCuentaGuardada = new GuardadoDeCuenta(-1, nombreus, fechaus, celularus, direccionus);

            //nueva.AgregarDinero(1000);
            //nueva.RetirarDinero(789);

            //nueva.MostrarInformacionCuenta();
            //nuevaValidacion.MostrarInformacionCuenta();

            //FuncinoesAlmacenamiento.guardarCuenta(nueva);

            //Account ultimaCuenta = FuncinoesAlmacenamiento.obtenerUltimaCuenta();

            VistaDatosForm vista1_validacion = new VistaDatosForm(nuevaValidacionDeCuenta);
            VistaDatosForm vista2_guardado = new VistaDatosForm(nuevaCuentaGuardada);

            vista1_validacion.Text = "Validacion de la cuenta";
            vista2_guardado.Text = "Guardado de la cuenta";

            this.Hide();
            vista1_validacion.Show();
            vista2_guardado.Show();
            //this.Show();
            //MessageBox.Show($"Se creo una cuenta nueva para el cliente {nueva.nombreCliente}.");
        }

        private void CelularCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CelularMtb.Enabled = CelularCb.Checked;
        }

        private void DireccionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DireccionRtb.Enabled = DireccionCb.Checked;

        }
        private bool Validador_nombre(string rNombre)
        {
            if (!string.IsNullOrEmpty(rNombre) && rNombre.Length>2 && rNombre.Length<25)
            {
                return true;
            }

            return false;
        }

        public bool Validador_fecha(DateTime rFecha)
        {

            if (DateTime.Compare(rFecha, new DateTime(DateTime.Now.Year - 18, 12, 31)) > 0)
            {
                return false;
            }

            return true;
        }
    }
}
