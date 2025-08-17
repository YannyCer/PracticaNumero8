using UnityEngine;

public class Caracter1 : MonoBehaviour
{
    string numeroTexto1 = "1492";
    string numeroTexto2 = "1810";
    int num1, num2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        bool transform1 = int.TryParse(numeroTexto1, out num1);
        bool transform2 = int.TryParse(numeroTexto2, out num2);

        if (transform1 && transform2)
        {
            int res = num1 + num2;
            Debug.Log("Resultado de la suma: " + res);
        }
        else
        {
            Debug.Log("Error en la transformacion");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
