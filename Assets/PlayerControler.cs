using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10;


    [Header("Fire")]
    [SerializeField]
    private GameObject _minugunWaepon;
    [SerializeField]
    private GameObject _minugunLeft;
    [SerializeField]
    private GameObject _minugunRight;


    private float h;
    private float v;
    Rigidbody2D rb;

   
   
  


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

       
    }
   
        private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        rb.velocity = new Vector2( h * _speed, rb.velocity.y);

        if(Input.GetButton("Jump"))
        {
            Instantiate( _minugunWaepon.transform);
        }
        
    }
   
}
