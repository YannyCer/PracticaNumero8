using UnityEngine;

public class Jugadr : MonoBehaviour
{
    [SerializeField] public float limiteX = 7f;
    [SerializeField] public float velocidad = 10f;

    Vector3 mousePos2d;
    Vector3 mousePos3d;

     public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            Vector3 direccion = collision.contacts[0].point - transform.position;
            direccion = direccion.normalized;
            collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        }
    }

    void Update()
    {  
        Vector3 pos = transform.position;

        // Movimiento con mouse 
        if (Input.GetMouseButton(0))
        {
            mousePos2d = Input.mousePosition;
            mousePos2d.z = -Camera.main.transform.position.z;
            mousePos3d = Camera.main.ScreenToWorldPoint(mousePos2d);
            pos.x = mousePos3d.x;
        }
        else
        {
            // Movimiento con teclado o mando
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Joystick1Button0))
            {
                pos.x -= velocidad * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Joystick1Button2))
            {
                pos.x += velocidad * Time.deltaTime;
            }
        }

        // Limitar movimiento
        if (pos.x < -limiteX) pos.x = -limiteX;
        if (pos.x > limiteX) pos.x = limiteX;

        transform.position = pos;
    }
}
