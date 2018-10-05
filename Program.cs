using System;
using System.Collections.Generic;

namespace Laboratorio7
{
    class MainClass
    {

        public static void MostrarNodo(Nodo<string> nodo)
        {
            string izquierdo = nodo.hijoIzquierdo == null ? "null" : nodo.hijoIzquierdo.Valor;
            string derecho = nodo.hijoDerecho == null ? "null" : nodo.hijoDerecho.Valor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEstás en el nodo {0}, su hijo izquierdo es {1} y su nodo derecho es {2}", nodo.Valor, izquierdo, derecho);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Main(string[] args)
        {
            // No es necesario hacerlo de la siguiente manera, pero
            // así nos ahorramos de crear los nodos desde la A a la H

            Dictionary<char, Nodo<string>> nodos = new Dictionary<char, Nodo<string>>();

            foreach (char letra in "ABCDEFGHI")
                nodos[letra] = new Nodo<string>(letra.ToString());

            // Ya tenemos creados los nodos de la A a la H, ahora armamos el arbol de la imagen

            ArbolBinario<string> arbolBinario = new ArbolBinario<string>
            {
                raiz = nodos['F']
            };

            nodos['F'].hijoIzquierdo = nodos['B'];
            nodos['F'].hijoDerecho = nodos['G'];

            nodos['B'].hijoIzquierdo = nodos['A'];
            nodos['B'].hijoDerecho = nodos['D'];

            nodos['D'].hijoIzquierdo = nodos['C'];
            nodos['D'].hijoDerecho = nodos['E'];

            nodos['G'].hijoDerecho = nodos['I'];

            nodos['I'].hijoIzquierdo = nodos['H'];

            // Implementamos un pequeño programa en consola para ir viendo cada nodo

            Nodo<string> nodoActual = arbolBinario.raiz;
            string opcion;

            // Configuración consola
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                MostrarNodo(nodoActual);

                Console.WriteLine("\n¿Cuál nodo quieres visitar ahora?");
                Console.WriteLine("[1] Izquierdo");
                Console.WriteLine("[2] Derecho");
                Console.WriteLine("[3] Padre\n");

                opcion = Console.ReadLine();
                Nodo<string> nuevoNodo = null;

                switch (opcion)
                {
                    case "1":
                        nuevoNodo = nodoActual.hijoIzquierdo;
                        break;
                    case "2":
                        nuevoNodo = nodoActual.hijoIzquierdo;
                        break;
                    case "3":
                        nuevoNodo = nodoActual.padre;
                        break;
                    default:
                        break;
                }

                if (nuevoNodo == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEl nodo seleccionado no existe\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                }
                else
                {
                    nodoActual = nuevoNodo;
                }

            } while (opcion != "0");


        }
    }
}
