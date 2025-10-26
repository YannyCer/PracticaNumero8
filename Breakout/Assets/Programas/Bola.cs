using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    bool isGameStarted;
    [SerializeField] public float velocidadBola = 10.0f;
    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidbody;
    private ControlBorde control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control = GetComponent<ControlBorde>();
        if (control == null) control = Camera.main.GetComponent<ControlBorde>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        isGameStarted = false;
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        transform.position = posicionInicial;
        transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    void Update()
    {
        if (control.salioAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(gameObject);
        }

        if (control.salioArriba)
        {
            direccion = transform.position - ultimaPosicion;
            direccion.y *= -1;
            direccion = direccion.normalized;
            rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

        if (control.salioIzquierda)
        {
            direccion = transform.position - ultimaPosicion;
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

        if (control.salioDerecha)
        {
            direccion = transform.position - ultimaPosicion;
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody.linearVelocity = velocidadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                transform.SetParent(null);
                rigidbody.linearVelocity = velocidadBola * Vector3.up;
            }
        }
    }

    private void HabilitarControl()
    {
        control.enabled = true;
    }

    private void FixedUpdate()
    {
        ultimaPosicion = transform.position;
    }
}
