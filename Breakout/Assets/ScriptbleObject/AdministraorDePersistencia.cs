using UnityEngine;
using System.Collections.Generic;

public class AdministradorDePersistencia : MonoBehaviour
{
    public List<PuntajePersistente> ObjetosAGuardar;

    void OnEnable()
    {
        for (int i = 0; i < ObjetosAGuardar.Count; i++)
        {
            var so = ObjetosAGuardar[i];
            so.Cargar();
        }
    }

    void OnDisable()
    {
        for (int i = 0; i < ObjetosAGuardar.Count; i++)
        {
            var so = ObjetosAGuardar[i];
            so.Guardar();
        }
    }
}