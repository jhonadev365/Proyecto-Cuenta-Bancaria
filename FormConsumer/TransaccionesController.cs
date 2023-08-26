using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConsumer
{
    class TransaccionesController
    {
        transacciones modelo;

        public TransaccionesController(transacciones rModelo)
        {
            modelo = rModelo;
        }

        public void MostrarUltimaTransaccion()
        {
            Console.WriteLine($"Monto: {modelo.monto} - Fecha: {modelo.FechaString} - Lugar: {modelo.LugarTransaccion} - Tipo: {modelo.TipoDeTransaccionString}");
        }
    }
}
