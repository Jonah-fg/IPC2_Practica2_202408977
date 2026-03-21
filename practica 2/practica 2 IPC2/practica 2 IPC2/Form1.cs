using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_2_IPC2
{
    public partial class Form1 : Form
    {
        private NodoCola cola = new NodoCola();
        public Form1()
        {
            InitializeComponent();
            cmbEspecialidad.Items.Add("Medicina General");
            cmbEspecialidad.Items.Add("Pediatría");
            cmbEspecialidad.Items.Add("Ginecología");
            cmbEspecialidad.Items.Add("Dermatología");
            cmbEspecialidad.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarPacientes()
        {
            lstPacientes.Items.Clear();
            Nodo actual=cola.ObtenerFrente();
            while (actual !=null)
            {
                Paciente paciente=actual.Data;
                lstPacientes.Items.Add(paciente.Nombre + " | " + paciente.Especialidad + " | Edad: " + paciente.Edad + " | Espera: " + paciente.TiempoEspera + " min" + " | Atención: " + paciente.TiempoAtencion + " minutos");
                actual=actual.Siguiente;
            }
        }

        private void btonRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del paciente");
                return;
            }
            Paciente nuevoPaciente=new Paciente(txtNombre.Text, (int)numEdad.Value, cmbEspecialidad.SelectedItem.ToString());
            cola.Encolar(nuevoPaciente);

            MostrarPacientes();

            txtNombre.Clear();
            numEdad.Value=18;
            txtNombre.Focus();
            MessageBox.Show("Paciente registrado correctamene");
        }

        private void btonAtender_Click(object sender, EventArgs e)
        {
            if (cola.EstaVacia())
            {
                MessageBox.Show("No hay pacientes en espera");
                return;
            }

            Paciente atendido=cola.Desencolar();
            MessageBox.Show("PACIENTE ATENDIDO:\n\n" +"Nombre: " + atendido.Nombre + "\n" +"Edad: " + atendido.Edad + "\n" +"Especialidad: " + atendido.Especialidad + "\n" +"Tiempo atención: " + atendido.TiempoAtencion + " min\n" + "Tiempo espera: " + atendido.TiempoEspera + " min\n" + "Tiempo total: " + atendido.TiempoTotal + " minutos");
            MostrarPacientes();
        }

        private void picGrafica_Click(object sender, EventArgs e)
        {

        }

        private void btonGrafica_Click(object sender, EventArgs e)
        {
            string contenido = cola.GenerarDOT();
            File.WriteAllText("cola.dot", contenido);
            Process.Start("cmd", "/c dot -Tpng cola.dot -o cola.png");
            MessageBox.Show("Archivo .dot generado correctamente");
        }
    }
}
