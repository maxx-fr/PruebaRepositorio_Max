using UnityEngine;

public class movimientosItem : MonoBehaviour
{
    public Vector3 rotacionItem;
    public float velocidadRotacion = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacionItem *  Time.deltaTime * velocidadRotacion);
    }
}
