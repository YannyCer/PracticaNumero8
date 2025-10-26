using UnityEngine;
using System;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler EnCasoDeEspacioPresionado;

    void Start()
    {
        EnCasoDeEspacioPresionado += EventoEscuchado;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnCasoDeEspacioPresionado?.Invoke(this, EventArgs.Empty);
            MiEventoUnity?.Invoke(); // Corregido
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El evento se escuchó correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("El evento se disparó correctamente");
    }
}
