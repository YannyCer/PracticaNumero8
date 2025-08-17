using UnityEngine;

public class ScriptFalse1 : MonoBehaviour
{
    public bool falso = false;  
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        falso = !falso;

        if (falso)
        {
            rend.material.color = Color.white;
            Debug.Log("Cubo es TRUE");
        }
        else
        {
            rend.material.color = Color.black;
             Debug.Log("Cubo es FALSE");
        }
    }
}