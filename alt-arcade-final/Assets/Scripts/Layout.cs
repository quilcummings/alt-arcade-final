using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layout : MonoBehaviour
{
    public GameObject player;
    public GameObject bg;
    public GameObject cow;
   
    public float offset = 19.5f;
    
    
    void Update()
    {
        if (player.transform.position.x > offset -19.5)
        {
            Instantiate(bg, new Vector3(offset, 0, 0), Quaternion.identity);
            offset += 19.5f;
        }
        
        Debug.Log("Player Pos:" + player.transform.position.x);
        Debug.Log("Offset: " + offset);
        
    }
}
