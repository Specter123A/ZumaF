using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPoint : MonoBehaviour
{
     public Transform shootPoint;
    public GameObject bulletPrefab;

    public float force = 20f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        var bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        var rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * force, ForceMode2D.Impulse);
        }
}
