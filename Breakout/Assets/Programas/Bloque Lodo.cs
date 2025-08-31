using UnityEngine;

public class BloqueLodo : Bloque
{
    void Start()
    {
        resistencia = 2;
    }

    void Update()
    {
        base.RebotarBola();

        if (resistencia == 1)
        {
            transform.localScale = new Vector3(6, 1, 6);
        }
        else if (resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}