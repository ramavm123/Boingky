using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        float targetY = target.position.y;
        float currentY = transform.position.y;

        targetY = Mathf.SmoothDamp(currentY, targetY + 2f, ref velocity.y, smoothSpeed);

        Vector3 targetPosition = new Vector3(transform.position.x, targetY, transform.position.z);
        transform.position = targetPosition;
    }
}
