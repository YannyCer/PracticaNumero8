using UnityEngine;

public class PrimitivoAwake : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = ColorAleatorio();
    }

    Color ColorAleatorio()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
