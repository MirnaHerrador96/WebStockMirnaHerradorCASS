using System;
using System.Collections.Generic;
using System.Text;
using WebStockMirnaHerrador.Models;

namespace WebStockMirnaHerrador.DAO
{
    interface DAO_Inventario
    {
        void AddInventario(Inventario inventario);

        void UpdateInventario(Inventario inventario);

        void DeleteInventario(Inventario inventario);

        List<Inventario> AllInventario();
    }
}
