using UnityEngine;

public class MultiplicarMatrix : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      int[,] matriz1 = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[] matriz2 = { 7, 8, 9 };
        int[] matrizfinal = new int[matriz1.GetLength(0)];

        for (int i = 0; i < matriz1.GetLength(0); i++) 
        {
            int suma = 0;
            for (int j = 0; j < matriz1.GetLength(1); j++) 
            {
                suma += matriz1[i, j] * matriz2[j];
            }
            matrizfinal[i] = suma;
        }

        string textoMatriz1 = "";
        for (int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1.GetLength(1); j++)
            {
                textoMatriz1 += matriz1[i, j] + " ";
            }
            textoMatriz1 += "\n";
        }

        string textoMatriz2 = "";
        for (int i = 0; i < matriz2.Length; i++)
        {
            textoMatriz2 += matriz2[i] + " ";
        }

        string textoMatrizFinal = "";
        for (int i = 0; i < matrizfinal.Length; i++)
        {
            textoMatrizFinal += matrizfinal[i] + " ";
        }

        Debug.Log("Matriz:\n" + textoMatriz1);
        Debug.Log("Vector: " + textoMatriz2);
        Debug.Log("Resultado: " + textoMatrizFinal);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
