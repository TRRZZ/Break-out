using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
        int hp = 1;

        public void TakeDamage()
        {

            hp -= 1;

            if (hp == 0)
            {
               
                Destroy(gameObject);

            }
        }
    
}