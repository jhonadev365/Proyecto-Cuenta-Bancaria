using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClassLibrary
{
    public abstract class AccountBase
    {
        public abstract string nombreCliente { get; set; }
        public abstract double SaldoActual { get; }
        public abstract double comision { get; set; }
        public abstract bool AgregarDinero(double rMonto);
        public abstract bool RetirarDinero(double rMonto);
        protected abstract void agregarTransacciones(transacciones nuevaTransaccionRecivida);

    }
}
