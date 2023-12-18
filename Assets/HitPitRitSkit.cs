using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPitRitSkit : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision2D)
    {

        GameObject otherGameObject = collision2D.gameObject;
        Enemy hitEnemy = otherGameObject.GetComponent<Enemy>();

        if (hitEnemy != null) 
        {

            hitEnemy.TakeDamage();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
