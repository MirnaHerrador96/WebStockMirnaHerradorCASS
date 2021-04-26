using System;
using System.Collections.Generic;
using System.Text;

namespace WebStockMirnaHerrador.Models
{
    class SucursalElectrodomestico
    {
        private int id;
        private Sucursal id_sucursal;
        private Electrodomestico id_electrodomestico;
        private int cantidad_inventario;

        public SucursalElectrodomestico(int id, Sucursal id_sucursal, Electrodomestico id_electrodomestico, int cantidad_inventario)
        {
            this.id = id;
            this.id_sucursal = id_sucursal;
            this.id_electrodomestico = id_electrodomestico;
            this.cantidad_inventario = cantidad_inventario;
        }

        public int Id { get => id; set => id = value; }
        public int Cantidad_inventario { get => cantidad_inventario; set => cantidad_inventario = value; }
        internal Sucursal Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        internal Electrodomestico Id_electrodomestico { get => id_electrodomestico; set => id_electrodomestico = value; }
    }
}
