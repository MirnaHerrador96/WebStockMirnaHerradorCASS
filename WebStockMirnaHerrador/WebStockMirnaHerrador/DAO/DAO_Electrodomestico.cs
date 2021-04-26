using System;
using System.Collections.Generic;
using System.Text;
using WebStockMirnaHerrador.Models;

namespace WebStockMirnaHerrador.DAO
{
    interface DAO_Electrodomestico
    {
        void AddElectrodomestico(Electrodomestico electrodomestico);

        void UpdateElectrodomestico(Electrodomestico electrodomestico);

        void DeleteElectrodomestico(Electrodomestico electrodomestico);

        List<Electrodomestico> AllElectrodomestico();
    }
}
