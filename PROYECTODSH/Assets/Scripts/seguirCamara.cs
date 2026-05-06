using UnityEngine;

public class seguirCamara : MonoBehaviour
{
// Aquí conectaremos a nuestro jugador
    public Transform objetivo; 
    
    // Distancia a la que se mantendrá la cámara (Arriba y atrás)
    public Vector3 compensacion = new Vector3(0f, 4f, -7f); 

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // Sigue la posición del jugador más la compensación
            transform.position = objetivo.position + compensacion;
            
            // Hace que la cámara siempre mire hacia el jugador
            transform.LookAt(objetivo);
        }
    }
}
