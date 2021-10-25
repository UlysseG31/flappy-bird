using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float c_thrust;
    public float c_maxspeed_up;
    public float c_maxspeed_down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D c_rigid = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            c_rigid.AddForce(Vector2.up * c_thrust, ForceMode2D.Force);          
        }
        if (c_rigid.velocity.y > c_maxspeed_up)
        {
            c_rigid.velocity = new Vector2(0f, c_maxspeed_up);
        }
        if (c_rigid.velocity.y < -c_maxspeed_down)
        {
            c_rigid.velocity = new Vector2(0f, -c_maxspeed_down);
        }

    }
}
