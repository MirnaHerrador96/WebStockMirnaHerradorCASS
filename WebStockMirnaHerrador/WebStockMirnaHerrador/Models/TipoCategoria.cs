using System;
using System.Collections.Generic;
using System.Text;

namespace WebStockMirnaHerrador.Models
{
    class TipoCategoria
    {
        private int id;
        private string nombre_categoria;
        private bool habilitar_tipo;

        public TipoCategoria(int id, string nombre_categoria, bool habilitar_tipo)
        {
            this.id = id;
            this.nombre_categoria = nombre_categoria;
            this.habilitar_tipo = habilitar_tipo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }
        public bool Habilitar_tipo { get => habilitar_tipo; set => habilitar_tipo = value; }
    }
}
