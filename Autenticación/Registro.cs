using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autenticación
{
    public class Registro
    {
        public void RegistrarUsuario(Usuario u, string path) 
        {
            Console.WriteLine("Ingrese el nombre del usuario: ");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Username del usuario: ");
            u.Username = Console.ReadLine();
            Console.WriteLine("Ingrese la contrasena del usuario: ");
            u.Password = Console.ReadLine() ;
            string data = u.Nombre + "-" + u.Username + "-" + u.Password;
            var datos=ObtenerLineas(path);
            if (datos!= null)
            {
            datos.Add(data);
            File.WriteAllLines(path, datos);
            }
            else 
            {
                File.WriteAllText(path, data);
            }
        }
        public List<string> ObtenerLineas(string path) 
        {
            string[] data = null;
            if (File.Exists(path))
            {
                data = File.ReadAllLines(path);
            }
            else 
            {
                Console.WriteLine("El archivo no existe");
                return null;
            }
            List<string> datos = new List<string>();
            foreach (var item in data) 
            {
                datos.Add(item);
            }
            return datos;
        }
    }
}
