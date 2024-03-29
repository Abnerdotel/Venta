﻿
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    public class Producto : AuditEntity
    {

        public int idProducto { get; set; }

        public string? nombre { get; set; }
        public int idCategoria { get; set; }

        public int stock { get; set; }  

        public decimal precio { get; set; }
        public bool? esActivo { get; set; }


        /*
         * 
         * por defecto
       [idProducto]
      ,[nombre]
      ,[idCategoria]
      ,[stock]
      ,[precio]
      ,[esActivo]
     
        --Heredados de AuditEntity
      ,[IdUsuarioCreacion]
      ,[FechaMod]
      ,[IdUsuarioMod]
      ,[IdUsuarioElimino]
      ,[FechaElimino]
      ,[fechaRegistro].
      ,[Eliminado]
         */
    }
}
