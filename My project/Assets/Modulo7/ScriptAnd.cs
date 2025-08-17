using UnityEngine;

public class ScriptAnd : MonoBehaviour
{
    public bool estado = false;
    public ScriptFalse1 script1;
    public ScriptFalse2 script2;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {

        if (script1.falso && script2.falso)
        {
            estado = true;
            rend.material.color = Color.white;
            Debug.Log("Cubo AND True");
        }
        else
        {
            estado = false;
            rend.material.color = Color.black;
            Debug.Log("Cubo AND False");
        }    
    }
}