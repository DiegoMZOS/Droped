using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro1_documentos
{
    public partial class ESTRUCTURA : Form
    {
        public ESTRUCTURA()
        {
            InitializeComponent();
        }

        private void SeleccionarArchivosButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar archivos seleccionados en la ListBox
                    foreach (string archivo in openFileDialog.FileNames)
                    {
                        ArchivosListBox.Items.Add(archivo);
                    }
                }
            }
        }

        private void SeleccionarCarpetaButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    RutaDestinoTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void CambiarNombresButton_Click(object sender, EventArgs e)
        {
            // Obtener la ruta de destino
            string rutaDestino = RutaDestinoTextBox.Text;

            // Verificar que la ruta de destino no esté vacía
            if (string.IsNullOrEmpty(rutaDestino))
            {
                MessageBox.Show("Por favor, selecciona una ruta de destino válida.");
                return;
            }

            // Iterar sobre los archivos seleccionados
            foreach (string rutaArchivoOriginal in ArchivosListBox.Items)
            {
                try
                {
                    string nombreArchivo = Path.GetFileName(rutaArchivoOriginal);
                    string nuevaRuta = Path.Combine(rutaDestino, "PERU", "LIMA", nombreArchivo);

                    // Mueve o renombra el archivo a la nueva ruta
                    File.Move(rutaArchivoOriginal, nuevaRuta);

                    // Registra el cambio en el archivo de log
                    RegistrarEnLog($"Se cambió el nombre del archivo de {rutaArchivoOriginal} a {nuevaRuta}");
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir durante el proceso
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            MessageBox.Show("Proceso completado.");
        }

        private void RegistrarEnLog(string mensaje)
        {
            // Ruta del archivo de log
            string rutaLog = "log.txt";

            try
            {
                // Agrega una línea al archivo de log con la fecha y hora actual
                File.AppendAllText(rutaLog, $"{DateTime.Now}: {mensaje}\n");
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir al escribir en el archivo de log
                MessageBox.Show($"Error al escribir en el archivo de log: {ex.Message}");
            }
        }
    }
}