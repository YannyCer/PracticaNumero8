using UnityEngine;

public class Caracter2 : MonoBehaviour
{
    string oracion = "Rubius es mi streamer favorito";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string corte = oracion.Substring(5);
        Debug.Log("Oración : " + corte);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
