using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Criptomoneda
   {
      public int Id { get; set; }
      public required string Siglas { get; set; }
      public required string Descripcion { get; set; }
      public double Precio { get; set; }
   }
}
