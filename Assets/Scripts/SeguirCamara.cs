using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    private Transform camaraTransform;

    void Start()
    {
        // Encuentra la cámara en la escena
        camaraTransform = Camera.main.transform;
    }

    void Update()
    {
        // Sigue la posición de la cámara
        transform.position = new Vector3(camaraTransform.position.x, camaraTransform.position.y, transform.position.z);
    }
}
