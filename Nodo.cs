using System;
using System.Collections.Generic;

namespace ListLinked
{
    class Nodo
    {
        public int dato;
        public Nodo siguiente;

        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
    
}