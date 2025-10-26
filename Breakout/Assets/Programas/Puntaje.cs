using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto PuntajeAltoSO;

    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;

        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        PuntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"Puntaje Alto: {PuntajeAltoSO.puntajeMaximo}";
        PuntajeAltoSO.puntaje = 0;
    }

    void FixedUpdate()
    {
        PuntajeAltoSO.puntaje += 50;
    }

    void Update()
    {
        textoActual.text = $"Puntaje Actual: {PuntajeAltoSO.puntaje}";

        if (PuntajeAltoSO.puntaje > PuntajeAltoSO.puntajeMaximo)
        {
            PuntajeAltoSO.puntajeMaximo = PuntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"Puntaje Alto: {PuntajeAltoSO.puntajeMaximo}";
             PuntajeAltoSO.Guardar();
            // PlayerPrefs.SetInt("PuntajeAlto", PuntajeAltoSO.puntaje);
        }
    }
}
