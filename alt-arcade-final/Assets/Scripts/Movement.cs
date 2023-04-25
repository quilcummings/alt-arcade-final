using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    void Update()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, 10f);
        var rotationVector = transform.rotation.eulerAngles;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -1 * speed);
            
            rotationVector.z = -15;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
            rotationVector.z = 15;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        else
        {
            rotationVector.z = 0;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
}
