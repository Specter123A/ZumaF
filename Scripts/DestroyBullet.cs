using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public int damage;
    //if the object is out of view, destroy it
    private void OnBecameInvisible ()
    {
        Destroy(gameObject);
    }

    //if the object collides with Enemy, destroy it
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Ball"))
        {
        //The enemy can take 3 bullets
        //Each bullet increases the damage, and decreases the health by 1
        other.GetComponent<BallScript>().TakeDamage(damage);        //if health is less or equal to 0, it's killed
        VFX.Instance.InstantiateBulletEffects(other.transform);  //Play particle system on each hit
        ScoreManager.Instance.AddPoint();  //Add Points 
        Destroy(gameObject); //after it hits, destroy
        }
    }
}
