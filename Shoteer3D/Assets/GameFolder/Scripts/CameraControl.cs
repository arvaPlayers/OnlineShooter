using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    [Range(50, 500)]
    [SerializeField] float sensitivy;

    float minY = -90f, maxY = 90f;
    Transform oldPos;
    float yRot = 0f;
    void Start()
    {
        oldPos = transform;
    }


    void LateUpdate()
    {
        CamrRot();
       
    }
    void CamrRot()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sensitivy * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * sensitivy * Time.deltaTime;
        yRot -= rotY;
        yRot = Mathf.Clamp(yRot, minY, maxY);
        transform.localRotation = Quaternion.Euler(yRot, 0f, 0f);
        player.Rotate(Vector3.up * rotX);
    }
}
