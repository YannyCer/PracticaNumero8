using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool isGame = false;
    [SerializeField] float velocidaBola = 10f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 posicioninicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicioninicial.y += 3;
        this.transform.position = posicioninicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isGame = true;
            this.transform.SetParent(null);
            rb.linearVelocity = velocidaBola * Vector3.up;
        }
    }

    public void ResetearBola()
    {

    }
}