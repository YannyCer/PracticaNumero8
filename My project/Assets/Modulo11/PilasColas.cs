using UnityEngine;
using System.Collections.Generic;

public class PilasColas : MonoBehaviour
{
    public void PilaACola(Stack<string> pila)
    {
        string[] elementosPila = pila.ToArray();
        Queue<string> cola = new Queue<string>();

        for (int i = elementosPila.Length - 1; i >= 0; i--)
        {
            string elemento = elementosPila[i];
            Debug.Log("Pila -> " + elemento);
            cola.Enqueue(elemento);
        }

        string[] elementosCola = cola.ToArray();
        for (int i = 0; i < elementosCola.Length; i++)
        {
            Debug.Log("Cola -> " + elementosCola[i]);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack<string> pila = new Stack<string>();
        pila.Push("Teclado");
        pila.Push("Mouse");
        pila.Push("Laptop");
        pila.Push("USB");

        PilaACola(pila);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
