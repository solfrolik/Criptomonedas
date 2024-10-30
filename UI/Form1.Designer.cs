namespace UI
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         lblSiglas = new Label();
         lblDescripcion = new Label();
         lblPrecio = new Label();
         cmbCriptomoneda = new ComboBox();
         txtSiglas = new TextBox();
         txtDescripcion = new TextBox();
         txtPrecio = new TextBox();
         lblCriptomoneda = new Label();
         lblNuevoPrecio = new Label();
         txtNuevoPrecio = new TextBox();
         btnAgregarCriptomoneda = new Button();
         btnModificarPrecio = new Button();
         lblCriptoEliminar = new Label();
         cmbSeleccionarCriptomoneda = new ComboBox();
         btnEliminarCriptomoneda = new Button();
         dgvCriptomonedas = new DataGridView();
         ((System.ComponentModel.ISupportInitialize)dgvCriptomonedas).BeginInit();
         SuspendLayout();
         // 
         // lblSiglas
         // 
         lblSiglas.AutoSize = true;
         lblSiglas.Location = new Point(27, 20);
         lblSiglas.Name = "lblSiglas";
         lblSiglas.Size = new Size(56, 20);
         lblSiglas.TabIndex = 0;
         lblSiglas.Text = "SIGLAS";
         // 
         // lblDescripcion
         // 
         lblDescripcion.AutoSize = true;
         lblDescripcion.Location = new Point(25, 60);
         lblDescripcion.Name = "lblDescripcion";
         lblDescripcion.Size = new Size(101, 20);
         lblDescripcion.TabIndex = 1;
         lblDescripcion.Text = "DESCRIPCIÓN";
         // 
         // lblPrecio
         // 
         lblPrecio.AutoSize = true;
         lblPrecio.Location = new Point(27, 101);
         lblPrecio.Name = "lblPrecio";
         lblPrecio.Size = new Size(58, 20);
         lblPrecio.TabIndex = 2;
         lblPrecio.Text = "PRECIO";
         // 
         // cmbCriptomoneda
         // 
         cmbCriptomoneda.FormattingEnabled = true;
         cmbCriptomoneda.Location = new Point(163, 206);
         cmbCriptomoneda.Name = "cmbCriptomoneda";
         cmbCriptomoneda.Size = new Size(209, 28);
         cmbCriptomoneda.TabIndex = 3;
         // 
         // txtSiglas
         // 
         txtSiglas.Location = new Point(163, 17);
         txtSiglas.Name = "txtSiglas";
         txtSiglas.Size = new Size(209, 27);
         txtSiglas.TabIndex = 4;
         // 
         // txtDescripcion
         // 
         txtDescripcion.Location = new Point(163, 57);
         txtDescripcion.Name = "txtDescripcion";
         txtDescripcion.Size = new Size(209, 27);
         txtDescripcion.TabIndex = 5;
         // 
         // txtPrecio
         // 
         txtPrecio.Location = new Point(163, 101);
         txtPrecio.Name = "txtPrecio";
         txtPrecio.Size = new Size(209, 27);
         txtPrecio.TabIndex = 6;
         // 
         // lblCriptomoneda
         // 
         lblCriptomoneda.AutoSize = true;
         lblCriptomoneda.Location = new Point(25, 209);
         lblCriptomoneda.Name = "lblCriptomoneda";
         lblCriptomoneda.Size = new Size(121, 20);
         lblCriptomoneda.TabIndex = 7;
         lblCriptomoneda.Text = "CRIPTOMONEDA";
         // 
         // lblNuevoPrecio
         // 
         lblNuevoPrecio.AutoSize = true;
         lblNuevoPrecio.Location = new Point(25, 255);
         lblNuevoPrecio.Name = "lblNuevoPrecio";
         lblNuevoPrecio.Size = new Size(111, 20);
         lblNuevoPrecio.TabIndex = 8;
         lblNuevoPrecio.Text = "NUEVO PRECIO";
         // 
         // txtNuevoPrecio
         // 
         txtNuevoPrecio.Location = new Point(163, 255);
         txtNuevoPrecio.Name = "txtNuevoPrecio";
         txtNuevoPrecio.Size = new Size(209, 27);
         txtNuevoPrecio.TabIndex = 9;
         // 
         // btnAgregarCriptomoneda
         // 
         btnAgregarCriptomoneda.Location = new Point(243, 134);
         btnAgregarCriptomoneda.Name = "btnAgregarCriptomoneda";
         btnAgregarCriptomoneda.Size = new Size(129, 58);
         btnAgregarCriptomoneda.TabIndex = 10;
         btnAgregarCriptomoneda.Text = "AGREGAR CRIPTOMONEDA";
         btnAgregarCriptomoneda.UseVisualStyleBackColor = true;
         btnAgregarCriptomoneda.Click += btnAgregarCriptomoneda_Click;
         // 
         // btnModificarPrecio
         // 
         btnModificarPrecio.Location = new Point(243, 288);
         btnModificarPrecio.Name = "btnModificarPrecio";
         btnModificarPrecio.Size = new Size(118, 53);
         btnModificarPrecio.TabIndex = 11;
         btnModificarPrecio.Text = "MODIFICAR PRECIO";
         btnModificarPrecio.UseVisualStyleBackColor = true;
         btnModificarPrecio.Click += btnModificarPrecio_Click;
         // 
         // lblCriptoEliminar
         // 
         lblCriptoEliminar.AutoSize = true;
         lblCriptoEliminar.Location = new Point(12, 355);
         lblCriptoEliminar.Name = "lblCriptoEliminar";
         lblCriptoEliminar.Size = new Size(185, 20);
         lblCriptoEliminar.TabIndex = 12;
         lblCriptoEliminar.Text = "Seleccionar Criptomoneda";
         // 
         // cmbSeleccionarCriptomoneda
         // 
         cmbSeleccionarCriptomoneda.FormattingEnabled = true;
         cmbSeleccionarCriptomoneda.Location = new Point(203, 355);
         cmbSeleccionarCriptomoneda.Name = "cmbSeleccionarCriptomoneda";
         cmbSeleccionarCriptomoneda.Size = new Size(209, 28);
         cmbSeleccionarCriptomoneda.TabIndex = 13;
         // 
         // btnEliminarCriptomoneda
         // 
         btnEliminarCriptomoneda.Location = new Point(243, 389);
         btnEliminarCriptomoneda.Name = "btnEliminarCriptomoneda";
         btnEliminarCriptomoneda.Size = new Size(145, 53);
         btnEliminarCriptomoneda.TabIndex = 14;
         btnEliminarCriptomoneda.Text = "ELIMINAR CRIPTOMONEDA";
         btnEliminarCriptomoneda.UseVisualStyleBackColor = true;
         btnEliminarCriptomoneda.Click += btnEliminarCriptomoneda_Click;
         // 
         // dgvCriptomonedas
         // 
         dgvCriptomonedas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvCriptomonedas.Location = new Point(456, 20);
         dgvCriptomonedas.Name = "dgvCriptomonedas";
         dgvCriptomonedas.RowHeadersWidth = 51;
         dgvCriptomonedas.Size = new Size(455, 404);
         dgvCriptomonedas.TabIndex = 15;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(958, 450);
         Controls.Add(dgvCriptomonedas);
         Controls.Add(btnEliminarCriptomoneda);
         Controls.Add(cmbSeleccionarCriptomoneda);
         Controls.Add(lblCriptoEliminar);
         Controls.Add(btnModificarPrecio);
         Controls.Add(btnAgregarCriptomoneda);
         Controls.Add(txtNuevoPrecio);
         Controls.Add(lblNuevoPrecio);
         Controls.Add(lblCriptomoneda);
         Controls.Add(txtPrecio);
         Controls.Add(txtDescripcion);
         Controls.Add(txtSiglas);
         Controls.Add(cmbCriptomoneda);
         Controls.Add(lblPrecio);
         Controls.Add(lblDescripcion);
         Controls.Add(lblSiglas);
         Name = "Form1";
         Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)dgvCriptomonedas).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label lblSiglas;
      private Label lblDescripcion;
      private Label lblPrecio;
      private ComboBox cmbCriptomoneda;
      private TextBox txtSiglas;
      private TextBox txtDescripcion;
      private TextBox txtPrecio;
      private Label lblCriptomoneda;
      private Label lblNuevoPrecio;
      private TextBox txtNuevoPrecio;
      private Button btnAgregarCriptomoneda;
      private Button btnModificarPrecio;
      private Label lblCriptoEliminar;
      private ComboBox cmbSeleccionarCriptomoneda;
      private Button btnEliminarCriptomoneda;
      private DataGridView dgvCriptomonedas;
   }
}
