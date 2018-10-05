using System;
namespace Laboratorio7
{
    public class Nodo<T>
    {
        public Nodo<T> padre, hijoIzquierdo, hijoDerecho;

        public Nodo(T valor)
        {
            Valor = valor;
        }

        // Al definir la propiedad solo con "get", hará que esta sea readonly (podremos asignarle el valor en el constructor)
        public T Valor { get; }
    }
}
