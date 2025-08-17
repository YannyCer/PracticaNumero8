using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listadeCubos;
    public float factorDeEscalamiento;
    public int numCubos;

    void Start()
    {
        listadeCubos = new List<GameObject>();
    }

    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "Cubo Numero " + numCubos;

        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCubos.Add(tempGameObject);

        List<GameObject> objetosParaEliminar = new List<GameObject>();

        foreach (GameObject go in listadeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;

            if (escala <= 0.1f)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listadeCubos.Remove(go);
            Destroy(go);
        }
    }
}