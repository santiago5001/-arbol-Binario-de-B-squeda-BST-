using System;

namespace ProyectoBST
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            int opcion;
            do {
                Console.WriteLine("\n--- ÁRBOL BINARIO UEA ---");
                Console.WriteLine("1. Insertar | 2. Recorridos | 3. Min/Max/Altura | 4. Limpiar | 0. Salir");
                Console.Write("Opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                switch (opcion) {
                    case 1:
                        Console.Write("Valor: ");
                        arbol.Insertar(int.Parse(Console.ReadLine() ?? "0"));
                        break;
                    case 2:
                        Console.Write("\nInorden: "); arbol.Inorden(arbol.Raiz);
                        Console.Write("\nPreorden: "); arbol.Preorden(arbol.Raiz);
                        Console.Write("\nPostorden: "); arbol.Postorden(arbol.Raiz);
                        Console.WriteLine();
                        break;
                    case 3:
                        if (arbol.Raiz != null) {
                            Console.WriteLine($"Mín: {arbol.ObtenerMinimo(arbol.Raiz)} | Máx: {arbol.ObtenerMaximo(arbol.Raiz)} | Altura: {arbol.ObtenerAltura(arbol.Raiz)}");
                        } else Console.WriteLine("Árbol vacío.");
                        break;
                    case 4:
                        arbol.Raiz = null;
                        Console.WriteLine("Limpiado.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}