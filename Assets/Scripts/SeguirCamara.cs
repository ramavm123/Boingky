using UnityEngine;

public class SeguirCamara : MonoBehaviour
{
    private Transform camaraTransform;

    void Start()
    {
        // Encuentra la c�mara en la escena
        camaraTransform = Camera.main.transform;
    }

    void Update()
    {
        // Sigue la posici�n de la c�mara
        transform.position = new Vector3(camaraTransform.position.x, camaraTransform.position.y, transform.position.z);
    }
}
