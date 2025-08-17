using UnityEngine;

public class CuboEnDis : MonoBehaviour
{
    public GameObject PrefabCubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnEnable()
    {
        GameObject objToSpawn = Instantiate(PrefabCubo);
        objToSpawn.name = "CuboInstanciado";
        objToSpawn.transform.position = Vector3.one;

        objToSpawn.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
         Debug.Log("El prefab 'PrefabCubo' esta en Enable.");
    }

    void OnDisable()
    {
       GameObject objToSpawn = Instantiate(PrefabCubo);
       objToSpawn.name = "CuboInstanciado";
       objToSpawn.transform.position = Vector3.one;

       objToSpawn.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
       Debug.LogWarning("El prefab 'PrefabCubo' esta en disable.");
    }
}
