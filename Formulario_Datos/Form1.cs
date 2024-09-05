using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombres = tbnombres.Text;
            string apellidos = tbapellidos.Text;
            string edad = tbedad.Text;
            string estatura = tbestatura.Text;
            string telefono = tbtelefono.Text;
            //Obtener el genero selccionado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            //Crear una cadena con los datos
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero:{genero}";

            //Guardar los datos de un archivo de texto
            String rutaArchivo = "C:/Users/herna/OneDrive/Documentos/Datos form.txt";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
                //Mostrar un mensaje con los datos capturados
                MessageBox.Show("Datos capturados correctamente:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //limpaiar los controles despues de guardar
            tbnombres.Clear();
            tbapellidos.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
