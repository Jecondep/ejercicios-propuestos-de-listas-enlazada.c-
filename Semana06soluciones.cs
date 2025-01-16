Ejercicio 1
Para este ejercicio, crearemos una clase Nodoy una clase ListaEnlazadaque contendrá el método para contar los elementos.
using System;

public class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo temp = cabeza;
            while (temp.Siguiente != null)
            {
                temp = temp.Siguiente;
            }
            temp.Siguiente = nuevoNodo;
        }
    }

    public int ContarElementos()
    {
        int contador = 0;
        Nodo temp = cabeza;
        while (temp != null)
        {
            contador++;
            temp = temp.Siguiente;
        }
        return contador;
    }
}

Ejercicio 2: Invertir una lista enlazada
Para este ejercicio, implementaremos un método que invierte la lista enlazada.
  public void Invertir()
{
    Nodo anterior = null;
    Nodo actual = cabeza;
    Nodo siguiente = null;

    while (actual != null)
    {
        siguiente = actual.Siguiente; // Guardar el siguiente nodo
        actual.Siguiente = anterior;   // Invertir el enlace
        anterior = actual;             // Mover el anterior un paso adelante
        actual = siguiente;            // Mover el actual un paso adelante
    }
    cabeza = anterior; // Actualizar la cabeza de la lista
}
