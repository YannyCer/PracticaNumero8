using UnityEngine;

public class Cilcos2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] texto = { "Intentando", "programar", "una", "oracion", "en", "Modulo","Nueve" };

        string oracion = "";

        foreach (string juntartexto in texto)
        {
            oracion += juntartexto + " ";
        }

        Debug.Log(oracion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
