using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soapnet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public User(int id, string nombre, int edad)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
        }
    }
    public class Users
    {
        User[] usuarios = {
            new User(1, "Juan", 25),
            new User(2, "María", 30),
            new User(3, "Pedro", 28)
        };
        public List<User> ListarUsuarios()
        {
            return usuarios.ToList();
        }

        // Función para filtrar usuarios por nombre
        public List<User> FiltrarUsuariosPorNombre(string nombre)
        {
            var usuariosFiltrados = usuarios.Where(user => user.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
            return usuariosFiltrados.ToList();
        }
    }
}
