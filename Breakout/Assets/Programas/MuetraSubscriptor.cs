using UnityEngine;
using System;

public class MuestraSubscriptor : MonoBehaviour
{
    MuestraEventos subscriptor;

    void Start()
    {
        subscriptor = GetComponent<MuestraEventos>();
        subscriptor.EnCasoDeEspacioPresionado += MensajeEscuchadoPorElSubscriptor;
    }

    private void MensajeEscuchadoPorElSubscriptor(object sender, EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado desde la otra clase");
        subscriptor.EnCasoDeEspacioPresionado -= MensajeEscuchadoPorElSubscriptor;
    }
}
