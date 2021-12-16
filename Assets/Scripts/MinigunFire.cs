using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunFire : MonoBehaviour
{

    Rigidbody2D rb;
    [Header("Config Bullet")]
    [SerializeField]
    private float bulletSpeed = 2000 ;

    void Start()
    {
        // pegando o rb
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
