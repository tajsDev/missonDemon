using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class RigidbodySleep : MonoBehaviour
{
    private int sleepCountDown = 4;
    private Rigidbody rigid;
    private float seconds = 6f;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sleepCountDown > 0)
        {
            rigid.Sleep();
            sleepCountDown--;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        //When trigger is hit, check to see if it is projectile
        Goal proj = other.gameObject.GetComponent<Goal>();
        if (proj != null)
        {
            Invoke("destoryObject",seconds);
        } 
    }
    void destoryObject()
    {
        Destroy(this.gameObject);
    }
}
