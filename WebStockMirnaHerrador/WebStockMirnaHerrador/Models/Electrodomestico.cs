using System;
using System.Collections.Generic;
using System.Text;

namespace WebStockMirnaHerrador.Models
{
    class Electrodomestico
    {
        private int id;
        private string nombre_electrodomestico;
        private TipoCategoria id_tipo_categoria;
        private bool habilitar_producto;

        public Electrodomestico(int id, string nombre_electrodomestico, TipoCategoria id_tipo_categoria, bool habilitar_producto)
        {
            this.id = id;
            this.nombre_electrodomestico = nombre_electrodomestico;
            this.id_tipo_categoria = id_tipo_categoria;
            this.habilitar_producto = habilitar_producto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_electrodomestico { get => nombre_electrodomestico; set => nombre_electrodomestico = value; }
        public bool Habilitar_producto { get => habilitar_producto; set => habilitar_producto = value; }
        internal TipoCategoria Id_tipo_categoria { get => id_tipo_categoria; set => id_tipo_categoria = value; }
    }
}
