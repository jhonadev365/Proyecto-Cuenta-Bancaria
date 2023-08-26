using BooksClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConsumer
{
    public static class FuncinoesAlmacenamiento
    {
        const string rutaPrincipal = @"C:\temp";
        const string rutaClientes  = @"C:\temp2";
        const string formatoFecha = "yyyy:MM:dd HH:mm";

        static FuncinoesAlmacenamiento()
        {
            if (!verificarExitencia())
            {
                Directory.CreateDirectory(rutaPrincipal);
                Directory.CreateDirectory(rutaClientes);
            }
        }
        static bool verificarExitencia()
        {
            if (Directory.Exists(rutaPrincipal)&& Directory.Exists(rutaClientes))
            {
                return true;
            }
            return false;
        }

        public static Account obtenerUltimaCuenta()
        {
            Account ultimaCuenta = new Account();
            DirectoryInfo directory = new DirectoryInfo(rutaPrincipal);
            FileInfo[] grupo = directory.GetFiles();

            if (grupo.Length == 0)
            {
                return null;
            }

            FileInfo ultimoArchivoModificado = grupo.OrderByDescending(f => f.LastWriteTime).First();
            string rutaArchivo = ultimoArchivoModificado.FullName;
            string nombreArchivoRecuperado = Path.GetFileNameWithoutExtension(rutaArchivo);

            int idCuenta = Convert.ToInt32(nombreArchivoRecuperado);
            string nombreDelUsuario;

            using (StreamReader lecturaArchivo = File.OpenText(rutaArchivo))
            {
                string lineaInicial = lecturaArchivo.ReadLine();

                string[] partesCabecera = lineaInicial.Split('_');
                nombreDelUsuario = partesCabecera[1];

                DateTime fechaus;
                string numeroCelular;
                string direccion;
                string siguienteLinea;

                using (StreamReader lecturaUsuario = File.OpenText(rutaClientes+"\\"+nombreDelUsuario+".dat"))
                {
                    siguienteLinea = lecturaUsuario.ReadLine();

                    partesCabecera = siguienteLinea.Split('_');
                    
                    fechaus = DateTime.ParseExact(partesCabecera[1], formatoFecha, null);
                    numeroCelular = partesCabecera[2];

                    siguienteLinea = lecturaUsuario.ReadLine();
                    direccion = siguienteLinea;

                    while (!string.IsNullOrEmpty(siguienteLinea))
                    {
                        string lineaDireccion = siguienteLinea;
                        direccion += "\n" +lineaDireccion;
                        siguienteLinea = lecturaUsuario.ReadLine();
                    }
                }

                ultimaCuenta = new Account(idCuenta, nombreDelUsuario, fechaus, numeroCelular, direccion);

                siguienteLinea = lecturaArchivo.ReadLine();

                while (!string.IsNullOrEmpty(siguienteLinea))
                {
                    string lineaTransaccionesUsuario = siguienteLinea;
                    siguienteLinea = lecturaArchivo.ReadLine();
                    string[] partesTransacciones = lineaTransaccionesUsuario.Split('_');

                    string RtipoTransaccion = partesTransacciones[0];
                    double Rmonto = Convert.ToDouble(partesTransacciones[1]);
                    DateTime Rfecha= DateTime.ParseExact(partesTransacciones[2], formatoFecha, null);
                    string Rlugar = partesTransacciones[3];

                    switch (RtipoTransaccion)
                    {
                        case "Deposito":
                            ultimaCuenta.AgregarDinero(Rmonto, Rfecha, Rlugar);
                            break;
                        case "Retiro":
                            ultimaCuenta.RetirarDinero(Rmonto, Rfecha, Rlugar);
                            break;
                    }

                    //transacciones nuevaTransaccion = new transacciones(Rmonto, Rfecha, RtipoTransaccion, Rlugar);

                    //ultimaCuenta.agregarTransacciones(nuevaTransaccion);
                }
            }

            return ultimaCuenta;

        }

        public static bool guardarCuenta(Account rCuenta)
        {
            // Nombre del archivo    ID de la cuenta del usuario
            // Cabecera del archivo  numero de la cuenta y el nombre del cliente 
            // Contenido archivo     Historial de transacciones

            using (StreamWriter escritura = File.CreateText(rutaPrincipal + "\\" + rCuenta.NumeroCuenta + ".dat"))
            {
                escritura.WriteLine($"{rCuenta.NumeroCuenta}_{rCuenta.nombreCliente}");
                foreach (transacciones item in rCuenta.ListaDeTransacciones)
                {
                    string lineaTransaccion = $"{item.TipoDeTransaccionString}_{item.monto}_{item.FechaFuente.ToString(formatoFecha)}_{item.LugarTransaccion}";
                    escritura.WriteLine(lineaTransaccion);
                }
            }

            // Nombre del archivo    Nombre del usuario
            // Cabecera del archivo  Fecha de cumpleaños del usuario
            // Contenido archivo     direcciones del usuario

            FileInfo fileinfo = new FileInfo(rutaClientes+"\\"+rCuenta.nombreCliente+".dat");
            using (StreamWriter escritura = fileinfo.CreateText())
            {
                escritura.WriteLine($"{rCuenta.nombreCliente}_{rCuenta.FechaCumpleanios.ToString(formatoFecha)}_{rCuenta.celularCliente}");
                string[] DireccionesUsuario = rCuenta.direccionCliente.Split(new char[] { '\t', '\n' });
                foreach (string item in DireccionesUsuario)
                {
                    escritura.WriteLine(item);
                }
            }
            return false;
        }
    }
}
