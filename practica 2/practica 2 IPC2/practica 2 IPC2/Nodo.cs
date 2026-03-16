using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_IPC2
{
    internal class Nodo
    {
        public Paciente Data { get; set; }     
        public Nodo Siguiente { get; set; }   

        public Nodo(Paciente paciente)
        {
            Data=paciente;
            Siguiente = null;
        }
    }
}
