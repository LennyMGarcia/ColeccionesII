using System;
using System.Collections.Generic;

namespace ColeccionesII
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach(int numero in new int[] {10, 8, 6, 4, 2 ,0})
            {
                //por cada numero en el array agregalo a la primera posicion eso es addfirts lo contrario es addlast
                numeros.AddFirst(numero);
            }
            numeros.Remove(6);
            //este es para leer
            /*foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }*/
            //En el nodo de la linkedList se pone el primer numero y mientras sea diferente de nulo avanza al siguiente
            for(LinkedListNode<int> nodo = numeros.First; nodo!=null;nodo=nodo.Next)
            {//mientras el nmero sea del valor del nodo se imprime nmero
                int nmero = nodo.Value;

                Console.WriteLine(nmero);
            }
            //Objeto de tipo noodo con valor 15
            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
            //se pone un valor de tipo nodo al primer numero
            numeros.AddFirst(nodoImportante);

        }
    }
}
