using UnityEngine;

public class PrimitivoFixed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    
       void FixedUpdate()
    {
        GetComponent<MeshRenderer>().material.color = ColorAleatorio();
    }

    Color ColorAleatorio()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}