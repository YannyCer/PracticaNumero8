using System;
using UnityEngine;

public class ListaDescendente : MonoBehaviour
{
    public int[] OrdenarDescendente(int[] arreglo)
    {
        int[] num = (int[])arreglo.Clone();
        Array.Sort(num);
        Array.Reverse(num);
        return num;
    }

    void Start()
    {
        int[] arreglo = { 100, 50, 25, 10, 64 };
        int[] num = OrdenarDescendente(arreglo);
        Debug.Log(string.Join(", ", num));
    }

    void Update()
    {
    }
}
