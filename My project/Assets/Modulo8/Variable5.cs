using UnityEngine;

public class Variable5 : MonoBehaviour
{
    double fib = 1.6180339;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string numeroNuevo = fib.ToString("F4");
        Debug.Log("Numero resumen: " + numeroNuevo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
