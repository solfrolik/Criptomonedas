using BLL;

namespace UI
{
   public partial class Form1 : Form
   {
      private CriptomonedaBLL negocio = new CriptomonedaBLL();
      public Form1()
      {
         InitializeComponent();
         CargarCriptomonedas();
      }
      private void CargarCriptomonedas()
      {
         var criptomonedas = negocio.ObtenerTodas();
         dgvCriptomonedas.DataSource = criptomonedas;
         cmbCriptomoneda.DataSource = criptomonedas;
         cmbCriptomoneda.DisplayMember = "Siglas";
         cmbCriptomoneda.ValueMember = "Id";

         cmbSeleccionarCriptomoneda.DataSource = criptomonedas;
         cmbSeleccionarCriptomoneda.DisplayMember = "Siglas";
         cmbSeleccionarCriptomoneda.ValueMember = "Id";
      }

      private void btnAgregarCriptomoneda_Click(object sender, EventArgs e)
      {
         try
         {
            negocio.CrearCriptomoneda(txtSiglas.Text, txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text));
            CargarCriptomonedas(); 
            MessageBox.Show("Criptomoneda agregada correctamente.");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnModificarPrecio_Click(object sender, EventArgs e)
      {
         try
         {
            int id = Convert.ToInt32(cmbCriptomoneda.SelectedValue);
            double nuevoPrecio = Convert.ToDouble(txtNuevoPrecio.Text);
            negocio.ActualizarPrecio(id, nuevoPrecio);
            CargarCriptomonedas(); 
            MessageBox.Show("Precio modificado correctamente.");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnEliminarCriptomoneda_Click(object sender, EventArgs e)
      {
        
         if (cmbSeleccionarCriptomoneda.SelectedValue != null)
         {
          
            int id = Convert.ToInt32(cmbSeleccionarCriptomoneda.SelectedValue);
            negocio.EliminarCriptomoneda(id);
            MessageBox.Show("Criptomoneda eliminada correctamente.");
         }
         else
         {
            MessageBox.Show("Por favor, selecciona una criptomoneda para eliminar.");
         }
      }
   }
}
