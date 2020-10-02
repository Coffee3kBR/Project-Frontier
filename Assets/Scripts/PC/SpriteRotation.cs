using System;
using UnityEngine;

public class SpriteRotation : MonoBehaviour
{
    public Transform cam;

    void Update()
    {
        Vector3 targetVector = cam.position - transform.position;
        float newYAngle = Mathf.Atan2(targetVector.x,targetVector.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(45f,-1 * newYAngle,0f);       
    }
}
