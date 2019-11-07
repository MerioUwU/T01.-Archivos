using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticación
{
    public class Login
    {
        public void IngresarDatos() 
        {
            Console.WriteLine("Ingresa tu nombre de Usuario: ");
            string username = Console.ReadLine();
            Console.WriteLine("Ingresa tu clave de paso: ");
            string password = Console.ReadLine();
            Usuario u = new Usuario();
            u.Username = username;
            u.Password = password;
            Registro r = new Registro();
            string ruta = "C:/Users/super/Documents/Datos.txt";
            List<string> Datos = r.ObtenerLineas(ruta);
            ValidarDatos(u, Datos);
        }
        public void ValidarDatos(Usuario u,List<string> Datos) 
        {
            List<Usuario> Usuarios = new List<Usuario>();
            foreach (var item in Datos) 
            {
                string[] info = item.Split('-');
                Usuarios.Add(new Usuario { Nombre = info[0], Username = info[1], Password = info[2] });
            }
            foreach (var user in Usuarios) 
            {
                if (u.Username == user.Username && u.Password == user.Password) 
                {
                    Welcome();
                }
            }
        }
        internal void Welcome() 
        {
            Console.Clear();
            Console.WriteLine("Congrats, chance y no repruebas");
            Console.ReadKey();
        }
    }
}
