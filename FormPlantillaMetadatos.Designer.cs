using System.Windows.Forms;

namespace Pro1_documentos
{
    partial class FormPlantillaMetadatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntcrearplantilla = new Button();
            button1 = new Button();
            txtmetadatoplantilla = new TextBox();
            dgPlantillasMetadatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPlantillasMetadatos).BeginInit();
            SuspendLayout();
            // 
            // bntcrearplantilla
            // 
            bntcrearplantilla.Location = new Point(1079, 4);
            bntcrearplantilla.Name = "bntcrearplantilla";
            bntcrearplantilla.Size = new Size(103, 35);
            bntcrearplantilla.TabIndex = 3;
            bntcrearplantilla.Text = "Crear Plantilla";
            bntcrearplantilla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(131, 16);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 4;
            button1.Text = "Agregar Metadato";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtmetadatoplantilla
            // 
            txtmetadatoplantilla.Location = new Point(346, 16);
            txtmetadatoplantilla.Name = "txtmetadatoplantilla";
            txtmetadatoplantilla.Size = new Size(452, 23);
            txtmetadatoplantilla.TabIndex = 5;
            // 
            // dgPlantillasMetadatos
            // 
            dgPlantillasMetadatos.AllowUserToAddRows = false;
            dgPlantillasMetadatos.AllowUserToDeleteRows = false;
            dgPlantillasMetadatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPlantillasMetadatos.Location = new Point(38, 154);
            dgPlantillasMetadatos.Name = "dgPlantillasMetadatos";
            dgPlantillasMetadatos.ReadOnly = true;
            dgPlantillasMetadatos.RowTemplate.Height = 25;
            dgPlantillasMetadatos.Size = new Size(1269, 256);
            dgPlantillasMetadatos.TabIndex = 6;
            // 
            // FormPlantillaMetadatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 539);
            Controls.Add(dgPlantillasMetadatos);
            Controls.Add(txtmetadatoplantilla);
            Controls.Add(button1);
            Controls.Add(bntcrearplantilla);
            Name = "FormPlantillaMetadatos";
            Text = "FormPlantillaMetadatos";
            ((System.ComponentModel.ISupportInitialize)dgPlantillasMetadatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bntcrearplantilla;
        private Button button1;
        private TextBox txtmetadatoplantilla;
        private DataGridView dgPlantillasMetadatos;
    }
}