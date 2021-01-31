using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target;
    public Vector3 offset;
    // x= 0 y = 2 z = -3 
    public float smoothSpeed = 5.0f;
    void Start(){

        offset = new Vector3(0,2,-3);
    }
    void LateUpdate(){

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed );

        transform.position = smoothedPosition;

        transform.LookAt(target);
    }


}
