using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class CriptomonedaDAL
   {
      private string connectionString = "Data Source=LAPTOP-A3HABLR6\\SQLEXPRESS;Initial Catalog=Criptmoneda;Integrated Security=True;";  

      public List<Criptomoneda> ObtenerTodas()
      {
         List<Criptomoneda> criptomonedas = new List<Criptomoneda>();
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Criptomoneda", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Criptomoneda cripto = new Criptomoneda
               {
                  Id = (int)reader["Id"],
                  Siglas = reader["Siglas"]?.ToString() ?? string.Empty,   
                  Descripcion = reader["Descripcion"]?.ToString() ?? string.Empty, 
                  Precio = Convert.ToDouble(reader["Precio"])
               };
               criptomonedas.Add(cripto);
            }
         }
         return criptomonedas;
      }

      public void AgregarCriptomoneda(Criptomoneda cripto)
      {
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Criptomoneda (Siglas, Descripcion, Precio) VALUES (@Siglas, @Descripcion, @Precio)", conn);
            cmd.Parameters.AddWithValue("@Siglas", cripto.Siglas);
            cmd.Parameters.AddWithValue("@Descripcion", cripto.Descripcion);
            cmd.Parameters.AddWithValue("@Precio", cripto.Precio);
            cmd.ExecuteNonQuery();
         }
      }

      
      public void ModificarPrecio(int id, double nuevoPrecio)
      {
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Criptomoneda SET Precio = @Precio WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Precio", nuevoPrecio);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
         }
      }
      public void EliminarCriptomoneda(int id)
      {
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Criptomoneda WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
         }
      }
   }
}
