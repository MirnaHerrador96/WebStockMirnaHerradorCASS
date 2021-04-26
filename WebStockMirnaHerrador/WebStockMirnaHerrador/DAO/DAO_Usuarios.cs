using System;
using System.Collections.Generic;
using System.Text;
using WebStockMirnaHerrador.Models;

namespace WebStockMirnaHerrador.DAO
{
    interface DAO_Usuarios
    {
        void AddUsuarios(Usuarios usuarios);

        void UpdateUsuarios(Usuarios usuarios);

        void DeleteUsuarios(Usuarios usuarios);
        List<Usuarios> AllUsuarios();

    }
}
