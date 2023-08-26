using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClassLibrary
{
    //ESTABLECEMOS UNA CLASE ANIDAD PARA LAS TRANSACCIONES
    public class transacciones
    {

        const double EMP_AMOUNT = 999.9;
        const string EMP_PLACE = "ANYWHERE";

        double _MontoTransaccion;
        DateTime _FechaTransaccion;
        string _LugarTransaccion;
        tipoDeTransaccion _TipoTra; ////ESTABLECEMOS EL TIPO DE TRANSACCION EN LA CLASE

        public string LugarTransaccion
        {
            get
            {
                return _LugarTransaccion;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _LugarTransaccion = EMP_PLACE;
                }
                else
                {
                    _LugarTransaccion = value;
                }
            }
        }
        public double monto
        {
            get
            {
                return _MontoTransaccion;
            }
            set
            {
                if (Double.IsNaN(value))
                {
                    _MontoTransaccion = EMP_AMOUNT;
                }
                else
                {
                    _MontoTransaccion = value;
                }
            }
        }
        public string DetalleResumen
        {
            get
            {
                return TipoDeTransaccionString + $" exitoso - {monto}  - {FechaString}";
            }
        }  //PROPIEDAD PARA EL listBox
        public string TipoDeTransaccionString
        {
            get
            {
                return (_TipoTra == tipoDeTransaccion.DEPOSITOS ? "Deposito" : "Retiro");
            }
        }
        public string FechaString
        {
            get
            {
                return _FechaTransaccion.ToString("yyyy/MM/dd hh:mm:dd");
            }
        }
        public DateTime FechaFuente
        {
            get
            {
                return _FechaTransaccion;
            }
        }
        public transacciones()
        {
            _MontoTransaccion = 0.0d;
            _FechaTransaccion = new DateTime(1999, 1, 1);
            _LugarTransaccion = "DEFAULT PLACE";
            _TipoTra = tipoDeTransaccion.DEPOSITOS;
        }
        public transacciones(double rMontoTransaccion, tipoDeTransaccion tipo)
        {
            _MontoTransaccion = rMontoTransaccion;
            _FechaTransaccion = DateTime.Now;
            _LugarTransaccion = "Banco";
            _TipoTra = tipo;
        }
        public transacciones(double rMontoTransaccion, DateTime rFecha,  string rLugar, string rTipo)
        {
            _MontoTransaccion = rMontoTransaccion;
            _FechaTransaccion = rFecha;
            _LugarTransaccion = rLugar;
            switch (rTipo)
            {
                case "Deposito":
                    _TipoTra = tipoDeTransaccion.DEPOSITOS;
                    break;
                case "Retiro":
                    _TipoTra = tipoDeTransaccion.RETIROS;
                    break;
                default:
                    _TipoTra = tipoDeTransaccion.DEPOSITOS;
                    break;
            }
        }
        public transacciones(transacciones rTransaccion)
        {
            _MontoTransaccion = rTransaccion._MontoTransaccion;
            _FechaTransaccion = rTransaccion._FechaTransaccion;
            _LugarTransaccion = rTransaccion._LugarTransaccion;
            _TipoTra = rTransaccion._TipoTra;
        }

    }

    //DEFINIMOS UN CONJUNTO DE VALORES CONSTANTES CON enum
    public enum tipoDeTransaccion
    {
        DEPOSITOS,
        RETIROS
    }
}
