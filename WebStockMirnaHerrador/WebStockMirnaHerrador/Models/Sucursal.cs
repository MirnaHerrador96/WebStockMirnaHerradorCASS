using System;
using System.Collections.Generic;
using System.Text;

namespace WebStockMirnaHerrador.Models
{
    class Sucursal
    {
        private int id;
        private string nombre_sucursal;
        private string telefono_sucursal;
        private bool habilitar_sucursal;

        public Sucursal(int id, string nombre_sucursal, string telefono_sucursal, bool habilitar_sucursal)
        {
            this.id = id;
            this.nombre_sucursal = nombre_sucursal;
            this.telefono_sucursal = telefono_sucursal;
            this.habilitar_sucursal = habilitar_sucursal;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_sucursal { get => nombre_sucursal; set => nombre_sucursal = value; }
        public string Telefono_sucursal { get => telefono_sucursal; set => telefono_sucursal = value; }
        public bool Habilitar_sucursal { get => habilitar_sucursal; set => habilitar_sucursal = value; }
    }
}
