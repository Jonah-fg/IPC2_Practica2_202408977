using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_IPC2
{
    internal class NodoCola
    {
        private Nodo frente;  
        private Nodo final;    
        private int contador;     

        public NodoCola()
        {
            frente=null;
            final=null;
            contador=0;
        }

        public void Encolar(Paciente paciente)
        {
            Nodo nuevoNodo=new Nodo(paciente);
            if (final==null) 
            {
                frente=nuevoNodo;
                final=nuevoNodo;
            }
            else
            {
                final.Siguiente=nuevoNodo;  
                final=nuevoNodo;            
            }
            contador++;
            ActualizarTiemposEspera();
        }

        public Paciente Desencolar()
        {
            if (frente==null)  
                return null;

            Paciente pacienteAtendido=frente.Data;
            frente=frente.Siguiente;  // El segundo ahora es el primero

            if (frente==null) 
                final=null;

            contador--;
            ActualizarTiemposEspera();  
            return pacienteAtendido;
        }

        public Paciente VerPrimero()
        {
            if (frente==null)
                return null;
            return frente.Data;
        }

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> lista=new List<Paciente>();
            Nodo actual=frente;
            while (actual!=null)
            {
                lista.Add(actual.Data);
                actual=actual.Siguiente;
            }
            return lista;
        }

        private void ActualizarTiemposEspera()
        {
            int tiempoAcumulado=0;
            Nodo actual=frente;

            while (actual!= null)
            {
                actual.Data.TiempoEspera=tiempoAcumulado;
                tiempoAcumulado += actual.Data.TiempoAtencion;
                actual=actual.Siguiente;
            }
        }

        public bool EstaVacia()
        {
            return frente==null;
        }

        public int Contador
        {
            get {return contador; }
        }
    }
}
