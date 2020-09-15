using System;

namespace ListLinked
{
    class Program
    {
        private Nodo primero;
        private int size;

        public Program()
        {
            this.primero = null;
            this.size = 0;
        }

        public void ListaVacia()
        {
            if(primero == null)
            {
                Console.WriteLine("La lista esta vacia");
            }else
            {
                Console.WriteLine("   La lista Contiene datos");

            }

        }

        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato); // agregamos el nodo  
            nuevo.siguiente = primero;  // Ir al primer nodo
            primero = nuevo; // LO COLOCA DE PRIMERO
            size ++;

        }

        public int Size()
        {
            return size;

        }

        public void ImprimirNodos()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine($"[{actual.dato}] ->");
                actual = actual.siguiente;
            }
        }

        static void Main(string[] args)
        {
            Program lista = new Program();
            lista.ListaVacia();
            lista.addNodo(1);
            lista.addNodo(2);
            lista.addNodo(3);
            lista.addNodo(4);
            lista.addNodo(5);
            lista.addNodo(6);
            lista.ImprimirNodos();
            System.Console.Write($"Tamaño de la lista {lista.Size()}");     
            lista.ListaVacia();     
            Console.ReadKey();
        }
    }
}
