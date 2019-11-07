using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autenticación
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro r = new Registro();
            Usuario u = new Usuario();
            Login l = new Login();
            Console.WriteLine("Elige con un numero la opcion correcta: \n1.-Iniciar sesion\n2.-Registrarse");
            int opc = int.Parse(Console.ReadLine());
            if (opc == 1) 
            {
                l.IngresarDatos();
            }
            else if (opc == 2)
            {
                r.RegistrarUsuario(u, "C:/Users/super/Documents/Datos.txt");
            }

        }
    }
}
