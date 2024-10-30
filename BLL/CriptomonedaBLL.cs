using Dal;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CriptomonedaBLL
   {
      private CriptomonedaDAL dal = new CriptomonedaDAL();

      public List<Criptomoneda> ObtenerTodas()
      {
         return dal.ObtenerTodas();
      }

      public void CrearCriptomoneda(string siglas, string descripcion, double precio)
      {
         if (string.IsNullOrWhiteSpace(siglas))
            throw new Exception("Las siglas no pueden estar vacías.");
         if (precio <= 0)
            throw new Exception("El precio debe ser mayor que cero.");

         Criptomoneda cripto = new Criptomoneda
         {
            Siglas = siglas,
            Descripcion = descripcion,
            Precio = precio
         };

         dal.AgregarCriptomoneda(cripto);
      }

      public void ActualizarPrecio(int id, double nuevoPrecio)
      {
         if (nuevoPrecio <= 0)
            throw new Exception("El precio debe ser mayor que cero.");

         dal.ModificarPrecio(id, nuevoPrecio);
      }

      public void EliminarCriptomoneda(int id)
      {
         if (id <= 0)
            throw new Exception("Debe seleccionar una criptomoneda válida.");

         dal.EliminarCriptomoneda(id);
      }
   }
}
