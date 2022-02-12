using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{

    [SerializeField] Transform exitPoint;

    [SerializeField] float fireRate = 0.01f;

    [SerializeField] float damage = 0.1f;
  

    
    void FixedUpdate()
    {
        Fire();
    }
    void Fire()
    {

        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            fireRate -= Time.deltaTime;
            if (fireRate <= 0)
            {
                if (Physics.Raycast(exitPoint.position, exitPoint.transform.forward, out hit, Mathf.Infinity))
                {
                    if (hit.transform.tag == "Player")
                    {
                        hit.transform.GetComponent<PlayerHealt>().Damage(damage);
                        fireRate = 0.1f;
                    }
                }  
            }
        }
    }
}
