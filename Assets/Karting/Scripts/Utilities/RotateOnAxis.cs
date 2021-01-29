﻿using UnityEngine;

public class RotateOnAxis : MonoBehaviour
{
    [Tooltip("Applies a rotation of eulerAngles.z degrees around the z-axis, eulerAngles.x degrees around the x-axis, and eulerAngles.y degrees around the y-axis (in that order).")]
    public Vector3 rotationSpeed;
    //회전 속도에 맞춰 회전 함 
    void Update()
    {
        transform.Rotate(rotationSpeed);
    }
}
