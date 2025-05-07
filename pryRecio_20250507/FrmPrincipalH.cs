using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRecio_20250507
{
    public partial class FrmPrincipalH : Form
    {
        public FrmPrincipalH()
        {
            InitializeComponent();
        }

        private void FrmPrincipalH_Load(object sender, EventArgs e)
        {
            // Agrega los nombres al ComboBox
            comboBoxNombres.Items.Add("Batman");
            comboBoxNombres.Items.Add("Superman");
            comboBoxNombres.Items.Add("Sheldon");
            comboBoxNombres.Items.Add("Hellboy");

            // Selección por defecto
            comboBoxNombres.SelectedIndex = 0;

            // Evento de selección
            comboBoxNombres.SelectedIndexChanged += comboBoxNombres_SelectedIndexChanged;
        }

        private void comboBoxNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreSeleccionado = comboBoxNombres.SelectedItem.ToString();
            string rutaImagen = "";

            
            switch (nombreSeleccionado)
            {
                case "Batman":
                    rutaImagen = @"4f25664671c99280937c966afce5ca4c.jpg";
                    break;
                case "Superman":
                    rutaImagen = @"descarga (2).jpg";
                    break;
                case "Sheldon":
                    rutaImagen = @"descarga.jpg";
                    break;
                case "Hellboy":
                    rutaImagen = @"descarga (1).jpg";
                    break;
            }

            try
            {
                pictureBoxImagen.Image = Image.FromFile(rutaImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los NumericUpDown
            int valor1 = (int)numericUDFuerza.Value;
            int valor2 = (int)numericUDDestreza.Value;

            // Ruta del archivo (puedes cambiarla a donde quieras guardar)
            string rutaArchivo = "resultado.txt";

            // Contenido a escribir
            string contenido = $"Valor 1: {valor1}\r\nValor 2: {valor2}";

            try
            {
                // Escribir el archivo
                File.WriteAllText(rutaArchivo, contenido);
                MessageBox.Show("Archivo creado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.Message);
            }
        }
    }
}
