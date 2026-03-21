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
            frente = null;
            final = null;
            contador = 0;
        }

        public void Encolar(Paciente paciente)
        {
            Nodo nuevoNodo = new Nodo(paciente);
            if (final == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
            contador++;
            ActualizarTiemposEspera();
        }

        public Paciente Desencolar()
        {
            if (frente == null)
                return null;

            Paciente pacienteAtendido = frente.Data;
            frente = frente.Siguiente;
            if (frente == null)
                final = null;

            contador--;
            return pacienteAtendido;
        }

        public Paciente VerPrimero()
        {
            if (frente == null)
                return null;
            return frente.Data;
        }

        private void ActualizarTiemposEspera()
        {
            int tiempoAcumulado = 0;
            Nodo actual = frente;

            while (actual != null)
            {
                actual.Data.TiempoEspera = tiempoAcumulado;
                tiempoAcumulado += actual.Data.TiempoAtencion;
                actual = actual.Siguiente;
            }
        }

        public bool EstaVacia()
        {
            return frente ==null;
        }

        public Nodo ObtenerFrente()
        {
            return frente;
        }
        public string GenerarDOT()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("digraph Cola {");
            sb.AppendLine("rankdir=LR;");

            sb.AppendLine("node [shape=box, style=filled, color=lightblue, fontname=\"Arial\"];");

            Nodo actual=frente;
            int i = 0;

            sb.AppendLine("inicio [label=\"FRENTE\", shape=plaintext];");

            while (actual!= null)
            {
                sb.AppendLine(
                    $"nodo{i} [label=\"{actual.Data.Nombre}\\nEspera: {actual.Data.TiempoEspera} min\\nAtención: {actual.Data.TiempoAtencion} min\"];"
                );

                if (i==0)
                {
                    sb.AppendLine("inicio ->nodo0;");
                }

                if (actual.Siguiente!= null)
                {
                    sb.AppendLine($"nodo{i} -> nodo{i + 1};");
                }

                actual = actual.Siguiente;
                i++;
            }

            sb.AppendLine("fin [label=\"FINAL\", shape=plaintext];");
            if (i >0)
            {
                sb.AppendLine($"nodo{i - 1} -> fin;");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}