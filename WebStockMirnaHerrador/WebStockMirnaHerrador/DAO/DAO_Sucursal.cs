using System;
using System.Collections.Generic;
using System.Text;
using WebStockMirnaHerrador.Models;

namespace WebStockMirnaHerrador.DAO
{
    interface DAO_Sucursal
    {
        void AddSucursal(Sucursal sucursal);

        void UpdateSucursal(Sucursal sucursal);

        void DeleteSucursal(Sucursal sucursal);

        List<Sucursal> AllSucursal();
    }
}
