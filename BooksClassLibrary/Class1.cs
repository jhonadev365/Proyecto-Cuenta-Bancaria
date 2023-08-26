using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace BooksClassLibrary
{
    public class Account : AccountBase, IValidadorCuenta
    {
        //PODEMOS DEFINIR REGIONES DE CODIGO PARA TENER MAYOR CONTROL SOBRE LA ESTRUCTURA DEL MISMO

        #region PROPIEDADES_CUENTA

        //CAMPOS DE VALOR ESTATICO
        public static double RangoCambio = 1.1d;
        public const string EMP_DIRECCION = "DESCONOCIDO";
        public const string EMP_CELULAR= "#######";
        
        //CAMPOS DE VALOR VARIABLE
        Customer _NuevoCliente;
        public override string nombreCliente
        {
            get
            {
                return _NuevoCliente.NombreCliente;
            }
            set
            {
                _NuevoCliente.NombreCliente = value;
            }
        }
        public string celularCliente
        {
            get
            {
                return _NuevoCliente.NumeroCelular;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _NuevoCliente.NumeroCelular = EMP_CELULAR;
                }
                else
                {
                    _NuevoCliente.NumeroCelular = value;
                }
            }
        }
        public string direccionCliente
        {
            get
            {
                return _NuevoCliente.Direccion;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _NuevoCliente.Direccion = EMP_DIRECCION;
                }
                else
                {
                   _NuevoCliente.Direccion = value;
                }
            }
        }
        public DateTime FechaCumpleanios
        {
            get
            {
                return _NuevoCliente.FechaCumpleanios;
            }
        }
        int _NumeroCuenta;
        public int NumeroCuenta
        {
            get
            {
                return _NumeroCuenta;
            }
        }
        double _SaldoActual;
        public override double SaldoActual
        {
            get
            {
                return _SaldoActual;
            }
        }
        public double _Comision;
        public override double comision {
            get 
            {
                return _Comision;
            }
            set 
            {
                _Comision = value;
            }
        
        }
        public double SaldoEnTazaDeCambio
        {
            get
            {
                return _SaldoActual * RangoCambio;
            }
        }

        List<transacciones> _ListaDeTransacciones;
        public List<transacciones> ListaDeTransacciones
        {
            get
            {
                return _ListaDeTransacciones;
            }
        }
        public transacciones ultimaTransaccion
        {
            get
            {
                if (_ListaDeTransacciones.Count > 0)
                {
                    return _ListaDeTransacciones[_ListaDeTransacciones.Count - 1];
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        #region METODOS

        public override bool AgregarDinero(double rMonto)
        {
            bool estadoAgregacion = true;

            _SaldoActual += rMonto;
            transacciones exchange = new transacciones(rMonto, tipoDeTransaccion.DEPOSITOS);
            _ListaDeTransacciones.Add(exchange);

            return estadoAgregacion;
        }

        public override bool RetirarDinero(double rMonto)
        {
            bool estadoRetirar= true;

            if (_SaldoActual < rMonto)
            {
                estadoRetirar = false;
            }
            else
            {
                _SaldoActual -= rMonto;
                transacciones exchange = new transacciones(rMonto, tipoDeTransaccion.RETIROS);
                _ListaDeTransacciones.Add(exchange);
            }

            return estadoRetirar;
        }
        protected sealed override void agregarTransacciones(transacciones nuevaTransaccionRecibida)
        {
            ListaDeTransacciones.Add(nuevaTransaccionRecibida);

            switch (nuevaTransaccionRecibida.TipoDeTransaccionString)
            {
                case "Deposito":
                    _SaldoActual += nuevaTransaccionRecibida.monto;
                    break;
                case "Retiro":
                    _SaldoActual -= nuevaTransaccionRecibida.monto;
                    break;
            }
        }
        public void RetirarDinero(double rmonto, DateTime rfecha, string rlugar)
        {
            transacciones nuevaTransaccion = new transacciones(rmonto, rfecha, "Retiro", rlugar);
            this.agregarTransacciones(nuevaTransaccion);
        }
        public void AgregarDinero(double rmonto, DateTime rfecha, string rlugar)
        {
            transacciones nuevaTransaccion = new transacciones(rmonto, rfecha, "Deposito", rlugar);
            this.agregarTransacciones(nuevaTransaccion);
        }

        public bool ValidezNombreUsuario(string rNombreUsuario) 
        {
            if (!string.IsNullOrEmpty(rNombreUsuario) && rNombreUsuario.Length > 2 && rNombreUsuario.Length < 25)
            {
                return true;
            }

            return false;
        }
        public bool ValdezDeFechaDeNacimiento(DateTime rFechaNacimiento)
        {
            if (DateTime.Compare(rFechaNacimiento, new DateTime(DateTime.Now.Year - 18, 12, 31)) > 0)
            {
                return false;
            }

            return true;
        }
        public virtual bool ValidezMontoDeposito(double rMontoDeposito)
        {
            return true;
        }
        public virtual bool ValidezMontoRetiro(double rMontoRetiro)
        {
            return true;
        }

        public virtual void MostrarInformacionCuenta()
        {
            Console.WriteLine($"Identificador de la cuenta: {_NumeroCuenta} Saldo Actual: {_SaldoActual} tipo de cuenta regular");
        }
        #endregion

        #region CONSTRUCTORES

        //CONSTRUCTOR POR DEFECTO
        public Account()
        {
            _NuevoCliente = new Customer("DEFAULT", new DateTime(2000, 11, 11), null, null);
            _NumeroCuenta = Guid.NewGuid().GetHashCode();

            _SaldoActual = 0;
            _ListaDeTransacciones = new List<transacciones>();
        }
        //CONSTRUCTOR DE COPIA
        public Account(Account rAccount)
        {
            _NumeroCuenta = rAccount._NumeroCuenta;
            _SaldoActual = rAccount._SaldoActual;

            _ListaDeTransacciones = new List<transacciones>(rAccount._ListaDeTransacciones);
            _NuevoCliente = new Customer(rAccount._NuevoCliente);
        }

        //PONER PUBLICO CASO CONTRARIO SE CREA PRIVADO
        public Account(string rNombreCLiente, DateTime rFechaCumpleanios, string rNumeroCelular = null, string rDireccion = null)
        {
            _NuevoCliente = new Customer(rNombreCLiente, rFechaCumpleanios, rNumeroCelular, rDireccion);
            _NumeroCuenta = Guid.NewGuid().GetHashCode();

            _SaldoActual = 0;
            _ListaDeTransacciones = new List<transacciones>();
        }

        public Account(int numeroCuenta, string rNombreCLiente, DateTime rFechaCumpleanios, string rNumeroCelular = null, string rDireccion = null)
        {
            _NuevoCliente = new Customer(rNombreCLiente, rFechaCumpleanios, rNumeroCelular, rDireccion);
            _NumeroCuenta = numeroCuenta;

            _SaldoActual = 0;
            _ListaDeTransacciones = new List<transacciones>();
        }
        #endregion
    }
}
