using System;

namespace ProyectoBST
{
    public class ArbolBinario
    {
        public Nodo? Raiz;

        public void Insertar(int valor) {
            if (Raiz == null) Raiz = new Nodo(valor);
            else InsertarRec(Raiz, valor);
        }

        private void InsertarRec(Nodo actual, int valor) {
            if (valor < actual.Valor) {
                if (actual.Izquierdo == null) actual.Izquierdo = new Nodo(valor);
                else InsertarRec(actual.Izquierdo, valor);
            } else if (valor > actual.Valor) {
                if (actual.Derecho == null) actual.Derecho = new Nodo(valor);
                else InsertarRec(actual.Derecho, valor);
            }
        }

        public void Inorden(Nodo? n) { if (n != null) { Inorden(n.Izquierdo); Console.Write(n.Valor + " "); Inorden(n.Derecho); } }
        public void Preorden(Nodo? n) { if (n != null) { Console.Write(n.Valor + " "); Preorden(n.Izquierdo); Preorden(n.Derecho); } }
        public void Postorden(Nodo? n) { if (n != null) { Postorden(n.Izquierdo); Postorden(n.Derecho); Console.Write(n.Valor + " "); } }

        public int ObtenerMinimo(Nodo n) {
            while (n.Izquierdo != null) n = n.Izquierdo;
            return n.Valor;
        }

        public int ObtenerMaximo(Nodo n) {
            while (n.Derecho != null) n = n.Derecho;
            return n.Valor;
        }

        public int ObtenerAltura(Nodo? n) {
            if (n == null) return 0;
            return 1 + Math.Max(ObtenerAltura(n.Izquierdo), ObtenerAltura(n.Derecho));
        }
    }
}