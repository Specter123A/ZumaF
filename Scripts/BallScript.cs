using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int health;


    // if the hralth is less than 0, it will be killed 
    public void TakeDamage( int damageAmount)
    {
        health -= damageAmount;
        if(health <=0 )
        { 
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
