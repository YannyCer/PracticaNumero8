using UnityEngine;

public class ScriptAll : MonoBehaviour
{
    public bool estado = false;
    public ScriptOr script3;
    public ScriptAnd script4;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {

        if ((script3.estado && script4.estado) || (script3.estado || script4.estado))
        {
            estado = true;
            rend.material.color = Color.white;
            Debug.Log("ScriptAndOr TRUE");
        }
        else
        {
            estado = false;
            rend.material.color = Color.black;
            Debug.Log("ScriptAndOr FALSE");
        }
    }
}