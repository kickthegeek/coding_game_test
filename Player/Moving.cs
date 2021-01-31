using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving : MonoBehaviour
{

    public float speed = 2;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move hor and ver
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");
        //move ball
        Vector3 mvb = new Vector3 ( mh, 0.0f ,mv);

        rb.AddForce(mvb * speed);

        
    }
}
