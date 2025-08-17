using UnityEngine;

public class Variable1 : MonoBehaviour
{
    int Entero = 1;
    float Deci = 1.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Entero++;
        Debug.Log("El entero vale " + Entero);
    }

    void FixedUpdate()
    {
        Deci *= 1.1f;
        Debug.Log("El float vale " + Deci);
    }
}
