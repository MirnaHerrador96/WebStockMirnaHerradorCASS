using System;
using System.Collections.Generic;
using System.Text;
using WebStockMirnaHerrador.Models;

namespace WebStockMirnaHerrador.DAO
{
    interface DAO_SucursalElectrodomestico
    {
        void AddSucursalElectrodomestico(SucursalElectrodomestico sucursal__electrodomestico);

        void UpdateSucursalElectrodomestico(SucursalElectrodomestico sucursal_electrodomestico);

        void DeleteSucursalElectrodomestico(SucursalElectrodomestico sucursal_electrodomestico);

        List<SucursalElectrodomestico> AllSucursalElectrodomestico();
    }
}
