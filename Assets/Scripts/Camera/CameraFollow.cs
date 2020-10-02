using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    [Range(0.01f, 10.0f)]
    public float smoothFactor;
    public Vector3 offset;  
    void LateUpdate() 
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition =  Vector3.Lerp(transform.position, targetPosition, smoothFactor*Time.deltaTime);
        transform.position = smoothPosition;
        transform.LookAt(target);

    }
}