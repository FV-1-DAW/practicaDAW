using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoControlVersiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string nombre, apellidos, telefono, añadido;
            

            nombre = tNombre.Text;
            apellidos = tApellidos.Text;
            telefono = tTelefono.Text;

            añadido = tListaSocios.Text;

            tListaSocios.Text = añadido + "\n" + nombre + ", " + apellidos + ", " + telefono; 


        }
    }
}
