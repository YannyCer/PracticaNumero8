using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ListaDuplicados : MonoBehaviour
{
    public HashSet<int> BorrarDuplicados(List<int> lista)
    {
        return lista.Distinct().ToHashSet();
    }

    void Start()
    {
        List<int> listaDuplicados = new List<int>() { 1, 2, 2, 3, 4, 5, 1, 3 };
        HashSet<int> sinDuplicados = BorrarDuplicados(listaDuplicados);

        Debug.Log(string.Join(", ", sinDuplicados));
    }

    void Update()
    {
    }
}

