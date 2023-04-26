using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public static RayCast Instance;
    private float step; 
    public bool caught = false;

    private GameObject cow;

    void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down*10);
        Debug.DrawRay(transform.position, Vector2.down*10);

        RaycastHit2D hitRange = Physics2D.CircleCast(transform.position, 100f, Vector2.down*10);

        // if (hitRange.collider.gameObject.tag == "Cow")
        // {
        //     Debug.Log("HIT");
        // }


        if (hit.collider.gameObject.tag == "Cow" && Input.GetKey(KeyCode.X))
        {
            Debug.Log("Hit");
            caught = true;

            cow = hit.collider.gameObject;

        
        }

        if (caught)
        {
            step = 5 * Time.deltaTime;
            cow.transform.position = Vector2.MoveTowards(cow.transform.position, transform.position, step);
        }
    }
}
