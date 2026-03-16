using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_2_IPC2
{
    public partial class Form1 : Form
    {
        private NodoCola cola=new NodoCola();
        public Form1()
        {
            InitializeComponent();
            cmbEspecialidad.Items.Add("Medicina General");
            cmbEspecialidad.Items.Add("Pediatría");
            cmbEspecialidad.Items.Add("Ginecología");
            cmbEspecialidad.Items.Add("Dermatología");
            cmbEspecialidad.SelectedIndex=0;
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
    }
}
