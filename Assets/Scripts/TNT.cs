using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{
    private float radius = 3.0f;
    private void OnCollisionEnter(Collision other)
    {
        
               //When trigger is hit, check to see if it is projectile
        Projectile proj = other.gameObject.GetComponent<Projectile>();
        if (proj != null)
        {
            Vector3 center = transform.position;
            Collider[] hitColliders = Physics.OverlapSphere(center, radius);
            foreach (var hitCollider in hitColliders)
            {
                RigidbodySleep rs = hitCollider.gameObject.GetComponent<RigidbodySleep>();
                if(rs != null )
                {
                    Destroy(hitCollider.gameObject);
                }
            }
            ScoreTracker.score+=ScoreTracker.TNTscore;
            Destroy(this.gameObject);

        }  
    }
}
