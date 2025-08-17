using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    string hola = "Hola Mundo";
    string resultado = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < hola.Length; i++)
        {
            if (i % 2 == 0) 
            {
                resultado += hola[i];
            }
        }

        Debug.Log("" + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
