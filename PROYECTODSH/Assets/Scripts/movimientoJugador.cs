using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float movimientoX = Input.GetAxis("Vertical");
        float movimientoZ = Input.GetAxis("Horizontal");

        Vector3 movimiento = new Vector3(-movimientoX, 0f, movimientoZ);

        // Al quitar Space.World, Unity usa por defecto el espacio "Local"
        // Es decir: "Adelante" es donde mire la cápsula, no el norte del mapa.
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}
