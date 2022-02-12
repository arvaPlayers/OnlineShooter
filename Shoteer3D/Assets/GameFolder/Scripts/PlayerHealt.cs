using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealt : MonoBehaviour
{
    public float healt;
    public Image healtFill;
    void Start()
    {
        healt = 1;
    }
    private void Update()
    {
        
        Dead();
    }
    public void Damage(float damage)
    {
        healt -= damage;
        healtFill.fillAmount = healt;
    }
    void Dead()
    {
        if (healt <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
