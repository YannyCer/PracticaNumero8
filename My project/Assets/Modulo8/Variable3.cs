using UnityEngine;

public class Variable3 : MonoBehaviour
{
    int valor = 0;
    public Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        valor++;

        if (valor % 2 == 0)
        {
            rend.material.color = Color.white; 
            Debug.Log("Elcubo es blanco y su valor es: " + valor);
        }
        else
        {
            rend.material.color = Color.black;
            Debug.Log("Elcubo es negro y su valor es: " + valor);
        }
    }
}
