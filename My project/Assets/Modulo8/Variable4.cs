using UnityEngine;

public class Variable4 : MonoBehaviour
{
    string colorCubo = "rojo";  
    public Renderer rend;       

    void Start()
    {
        rend = GetComponent<Renderer>();

        switch (colorCubo.ToLower())
        {
            case "negro":
                rend.material.color = Color.black;
                Debug.Log("El cubo es negro");
                break;
            case "blanco":
                rend.material.color = Color.white;
                Debug.Log("El cubo es blanco");
                break;
            case "azul":
                rend.material.color = Color.blue;
                Debug.Log("El cubo es azul");
                break;
            case "rojo":
                rend.material.color = Color.red;
                Debug.Log("El cubo es rojo");
                break;
            default:
                rend.material.color = Color.gray;
                Debug.Log("Color no encontrado");
                break;
        }
    }

    void Update()
    {
       
    }
}