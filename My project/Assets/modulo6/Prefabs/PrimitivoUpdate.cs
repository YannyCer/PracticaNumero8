using UnityEngine;

public class PrimitivoUpdate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = ColorAleatorio();
    }

    Color ColorAleatorio()
    {
        return new Color(Random.value, Random.value, Random.value); 
    }
}