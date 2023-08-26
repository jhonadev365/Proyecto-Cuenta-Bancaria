using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClassLibrary
{
    public sealed class GuardadoDeCuenta : Account
    {
        const double MAX_RETIRO = 436;
        public GuardadoDeCuenta() : base()
        {
            comision = 0.005f;
        }

        public GuardadoDeCuenta(int numeroCuenta, string rNombreCLiente, DateTime rFechaCumpleanios, string rNumeroCelular = null, string rDireccion = null) : base(numeroCuenta, rNombreCLiente, rFechaCumpleanios
            , rNumeroCelular, rDireccion)
        {
            comision = 0.005f;
        }
        public override bool AgregarDinero(double rMonto)
        {
            if (!ValidezMontoDeposito(rMonto))
            {
                return false;
            }
            return base.AgregarDinero(rMonto);
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
