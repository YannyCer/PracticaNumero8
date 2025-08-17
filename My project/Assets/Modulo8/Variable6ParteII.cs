using UnityEngine;

public class Variable6ParteII : MonoBehaviour
{
    string nombreCompleto = "Juan Manuel Cerezo Leal";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       string[] sub = nombreCompleto.Split(' ');

       string nom1 = sub[0];
       string nom2 = sub[1]; 
       string nom3 = sub[2];
       string nom4 = sub[3];

       Debug.Log("Nombre: " + nom1);
       Debug.Log("Subnombre: " + nom2);
       Debug.Log("Apellido Padre: " + nom3);
       Debug.Log("Apellido Madre: " + nom4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
