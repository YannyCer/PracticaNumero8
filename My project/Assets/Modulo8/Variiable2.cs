using UnityEngine;

public class Variiable2 : MonoBehaviour
{
    float pi = 3.14f;
    float euler = 2.71f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        float resultado = pi + euler;

        int resultadofinal = (int)resultado; // Casteo explícito
        Debug.Log("Resultado: " + resultadofinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
