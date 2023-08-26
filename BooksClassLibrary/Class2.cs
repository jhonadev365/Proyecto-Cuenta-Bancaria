using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksClassLibrary
{
    public class Customer
    {
        string _NombreCliente;
        DateTime _FechaCumpleanios;
        string _NumeroCelular;
        string _Direccion;

        public string NombreCliente
        {
            get
            {
                return _NombreCliente;
            }
            set
            {
                _NombreCliente = value;
            }
        }

        public DateTime FechaCumpleanios
        {

            get
            {
                return _FechaCumpleanios;
            }
            set
            {
                _FechaCumpleanios = value;
            }
        }

        public string NumeroCelular
        {
            get
            {
                return _NumeroCelular;
            }
            set
            {
                _NumeroCelular = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                _Direccion = value;
            }
        }

        public Customer(string rNombreCLiente, DateTime rFechaCumpleanios, string rNumeroCelular = null, string rDireccion = null)
        {
            _NombreCliente = rNombreCLiente;
            _FechaCumpleanios = rFechaCumpleanios;
            _NumeroCelular = rNumeroCelular;
            _Direccion = rDireccion;
        }

        //CONSTRUCTOR PARA COPIA
        public Customer(Customer nuevoCliente)
        {
            _NombreCliente = nuevoCliente._NombreCliente;
            _FechaCumpleanios = nuevoCliente._FechaCumpleanios;
            _NumeroCelular = nuevoCliente._NumeroCelular;
            _Direccion = nuevoCliente._Direccion;
        }

        public void ActualizarNumero(string rNumeroCelular)
        {

        }
        public void ActualizarDireccion(string rDireccion)
        {

        }
    }
}
