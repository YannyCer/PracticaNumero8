using UnityEngine;

public class Variable6 : MonoBehaviour
{
    string nombreCompleto = "Juan Manuel Cerezo Leal";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string nombre = nombreCompleto.Substring(0, 4); 
        string segundoNombre = nombreCompleto.Substring(5, 6); 
        string apellidoPaterno = nombreCompleto.Substring(12, 6);
        string apellidoMaterno = nombreCompleto.Substring(19);

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Segundo Nombre: " + segundoNombre);
        Debug.Log("apellidoPaterno: " + apellidoPaterno);
        Debug.Log("apellidoMaterno: " + apellidoMaterno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
