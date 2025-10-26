using UnityEngine;

public class BloqueCemento : Bloque
{
    void Start()
    {
        resistencia = 5; 
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
     }
}