using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pro1_documentos
{
    public partial class FormPlantillaMetadatos : Form
    {
        public FormPlantillaMetadatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el texto de la TextBox
            string texto = txtmetadatoplantilla.Text;

            // Verificar si la TextBox no está vacía
            if (!string.IsNullOrEmpty(texto))
            {
                // Verificar si la columna ya existe
                if (!dgPlantillasMetadatos.Columns.Contains(texto))
                {
                    // Agregar una nueva columna al DataGridView
                    dgPlantillasMetadatos.Columns.Add(texto, "tbl_" + texto);
                }
                // Obtener la fila actual (o agregar una nueva si no hay)
                DataGridViewRow fila = dgPlantillasMetadatos.Rows.Count > 0 ? dgPlantillasMetadatos.Rows[0] : dgPlantillasMetadatos.Rows[dgPlantillasMetadatos.Rows.Add()];

                // Verificar si la columna está presente en la fila actual
                if (fila.Cells[dgPlantillasMetadatos.Columns[texto].Index] != null)
                {
                    // Asignar el valor a la celda
                    fila.Cells[dgPlantillasMetadatos.Columns[texto].Index].Value = texto;

                    // Limpiar la TextBox después de agregar
                    txtmetadatoplantilla.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese información en la caja de texto.");
            }
        }
    }
}
