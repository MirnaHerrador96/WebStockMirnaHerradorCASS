using System;
using System.Collections.Generic;
using System.Text;
using WebStockMirnaHerrador.Models;

namespace WebStockMirnaHerrador.DAO
{
    interface DAO_TipoCategoria
    {
        void AddTipoCategoria(TipoCategoria tipo_categoria);

        void UpdateTipoCategoria(TipoCategoria tipo_categoria);

        void DeleteTipoCategoria(TipoCategoria tipo_categoria);

        List<TipoCategoria> AllTipoCategoria();
    }
}
