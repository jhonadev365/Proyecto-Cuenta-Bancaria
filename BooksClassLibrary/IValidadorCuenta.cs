using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClassLibrary
{
    interface IValidadorCuenta
    {
        bool ValidezNombreUsuario(string rNombreUsuario);
        bool ValdezDeFechaDeNacimiento(DateTime rFechaNacimiento);
        bool ValidezMontoDeposito(double rMontoDeposito);
        bool ValidezMontoRetiro(double rMontoRetiro);
    }
}
