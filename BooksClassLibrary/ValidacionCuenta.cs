using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClassLibrary
{
    public sealed class ValidacionCuenta : Account
    {
        const double MIN_DEPOSITO = 377;
        const double MAX_RETIRO = 899;

        public ValidacionCuenta() : base()
        {
            comision = 0.01f;
        }

        public ValidacionCuenta(int numeroCuenta, string rNombreCLiente, DateTime rFechaCumpleanios, string rNumeroCelular = null, string rDireccion = null) : base(numeroCuenta, rNombreCLiente, rFechaCumpleanios 
            , rNumeroCelular, rDireccion)
        {
            comision = 0.01f;
        }

        public override bool AgregarDinero(double rMonto)
        {
            if (!ValidezMontoDeposito(rMonto))
            {
                return false;
            }

            double nuevoMontoLuegoDeLaComision = rMonto - rMonto * comision;

            return base.AgregarDinero(nuevoMontoLuegoDeLaComision);
        }

        public override bool RetirarDinero(double rMonto)
        {
            if (!ValidezMontoRetiro(rMonto))
            {
                return false;
            }

            double nuevoMontoLuegoDeLaComision = rMonto - rMonto * comision;

            return base.RetirarDinero(nuevoMontoLuegoDeLaComision);
        }

        public override void MostrarInformacionCuenta()
        {
            Console.WriteLine($"Validacion de la cuenta con saldo: {SaldoActual}, y comisión: {comision}");
        }

        public override bool ValidezMontoDeposito(double rMontoDeposito)
        {
            if (rMontoDeposito < MIN_DEPOSITO)
            {
                return false;
            }
            return true;
        }
        public override bool ValidezMontoRetiro(double rMontoRetiro)
        {
            if (rMontoRetiro > MAX_RETIRO)
            {
                return false;
            }

            return true;
        }
    }
}
