using System;
using System.Collections.Generic;
using UnityEngine;

public class ListAleatorio : MonoBehaviour
{
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();
        System.Random random = new System.Random();

        for (int i = 0; i < tamaño; i++)
        {
            int numero = random.Next(rangoInferior, rangoSuperior + 1);
            lista.Add(numero);
        }

        return lista;
    }

    void Start()
    {
        List<int> listaAleatoria = miFuncion(5, 0, 30);
        Debug.Log("Lista aleatoria: " + string.Join(", ", listaAleatoria));
    }

    void Update()
    {
    }
}