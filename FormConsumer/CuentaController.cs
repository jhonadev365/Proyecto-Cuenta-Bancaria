using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConsumer
{
    class CuentaController
    {
        private Account ModeloCuenta;

        public CuentaController(Account rCuenta)
        {
            ModeloCuenta = rCuenta;

        }

        public void MostrarSaldo()
        {
            Console.WriteLine("El saldo actual es: " + ModeloCuenta.SaldoActual);
        }
    }
}
