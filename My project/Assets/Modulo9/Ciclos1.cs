using UnityEngine;

public class Ciclos1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        int[] array3 = new int[5];

      
        for (int i = 0; i < 5; i++)
        {
            array1[i] = Random.Range(1, 50); 
            array2[i] = Random.Range(1, 50); 
        }

        for (int i = 0; i < 5; i++)
        {
            array3[i] = array1[i] + array2[i];
        }

        Debug.Log("Arreglo 1: " + string.Join(", ", array1));
        Debug.Log("Arreglo 2: " + string.Join(", ", array2));
        Debug.Log("Suma total: " + string.Join(", ", array3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
