using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] Transform exitPoint;
    float speed = 50f;
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        transform.Translate(exitPoint.forward * speed * Time.deltaTime);
    }
}
