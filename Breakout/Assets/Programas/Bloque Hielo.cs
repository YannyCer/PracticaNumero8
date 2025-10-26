using UnityEngine;

public class BloqueHielo : Bloque
{
    void Start()
    {
        resistencia = 2; 
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);

        if (resistencia == 1)
        {
            
            transform.localScale = new Vector3(2, 1, 2);
        }
        else if (resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}