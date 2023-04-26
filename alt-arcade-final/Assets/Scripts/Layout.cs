using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layout : MonoBehaviour
{
    public GameObject bg;
    public GameObject cow;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Instantiate(bg, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
