using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    public GameObject PrefabCubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        GameObject objToSpawn = Instantiate(PrefabCubo);
        objToSpawn.name = "CuboInstanciado";
        objToSpawn.transform.position = Vector3.one;

        objToSpawn.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

    }

}
