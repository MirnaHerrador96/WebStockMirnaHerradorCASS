using System;
using System.Collections.Generic;
using System.Text;

namespace WebStockMirnaHerrador.Models
{
    class Usuarios
    {
        private int id;
        private string nombre_usuario;
        private string apellido_usuario;
        private string username;
        private string clave;

        public Usuarios(int id, string nombre_usuario, string apellido_usuario, string username, string clave)
        {
            this.id = id;
            this.nombre_usuario = nombre_usuario;
            this.apellido_usuario = apellido_usuario;
            this.username = username;
            this.clave = clave;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Apellido_usuario { get => apellido_usuario; set => apellido_usuario = value; }
        public string Username { get => username; set => username = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
