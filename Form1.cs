namespace Pro1_documentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcesarArchivo(string rutaCompleta)
        {

            //tring rutaCompleta = txtrutacompleta.Text;

          

            if (!string.IsNullOrEmpty(rutaCompleta))
            {
                try
                {
                    // Obtiene el nombre del archivo con extensión
                    string nombreArchivo = Path.GetFileName(rutaCompleta);

                    // Remueve la extensión del archivo
                    string nombreSinExtension = Path.GetFileNameWithoutExtension(nombreArchivo);

                    // Utiliza la unidad D: como ruta base
                    string rutaBase = "D:";

                    // Separa el nombre sin extensión por guiones bajos
                    string[] partes = nombreSinExtension.Split('_');

                    // Crea subcarpetas con todas las partes excepto la última
                    for (int i = 0; i < partes.Length - 1; i++)
                    {
                        rutaBase = Path.Combine(rutaBase, partes[i]);
                        Directory.CreateDirectory(rutaBase);
                    }

                    // Combina la ruta base con la última parte para crear la carpeta final
                    string rutaCarpetaFinal = Path.Combine(rutaBase);

                    // Crea la carpeta final si no existe
                   // Directory.CreateDirectory(rutaCarpetaFinal);

                    // Combina la carpeta final con el nombre del archivo original para obtener la ruta completa final del archivo original
                   string rutaCompletaFinal = Path.Combine(rutaCarpetaFinal, partes[partes.Length - 1] + Path.GetExtension(nombreArchivo));
                    // Mueve el archivo a la carpeta final
                    //File.Create(rutaCompletaFinal);
                    File.Copy(rutaCompleta, rutaCompletaFinal);
                    Console.WriteLine("Se creo el pdf" + rutaCompleta);
                
                    
                    //MessageBox.Show("Ruta completa final: " + rutaCompletaFinal);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La ruta está vacía. Por favor, ingresa una ruta válida.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtén la lista de rutas de los archivos seleccionados
                    string[] rutasArchivos = openFileDialog.FileNames;

                    // Puedes hacer algo con la lista de rutas, como mostrarlas en una lista o procesar cada archivo individualmente
                    foreach (string rutaArchivo in rutasArchivos)
                    {
                        // Aquí puedes incluir la lógica para cada archivo seleccionado
                        // Puedes usar la lógica que hemos discutido previamente en este hilo
                        ProcesarArchivo(rutaArchivo);
                    }
                }
            }
        }
    }
}