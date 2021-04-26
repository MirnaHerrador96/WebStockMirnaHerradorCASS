using System;
using System.Collections.Generic;
using System.Text;

namespace WebStockMirnaHerrador.Models
{
    class Inventario
    {
        private int id;
        private SucursalElectrodomestico id_sucursal_electrodomestico;
        private int cantidad_entradas_salidas;
        private string movimiento;

        public Inventario(int id, SucursalElectrodomestico id_sucursal_electrodomestico, int cantidad_entradas_salidas, string movimiento)
        {
            this.id = id;
            this.id_sucursal_electrodomestico = id_sucursal_electrodomestico;
            this.cantidad_entradas_salidas = cantidad_entradas_salidas;
            this.movimiento = movimiento;
        }

        public int Id { get => id; set => id = value; }
        public int Cantidad_entradas_salidas { get => cantidad_entradas_salidas; set => cantidad_entradas_salidas = value; }
        public string Movimiento { get => movimiento; set => movimiento = value; }
        internal SucursalElectrodomestico Id_sucursal_electrodomestico { get => id_sucursal_electrodomestico; set => id_sucursal_electrodomestico = value; }
    }
}
