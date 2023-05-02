using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject ufo;
    
    void Update()
    {
        float x = ufo.transform.position.x;
        float y = transform.position.y;

        transform.position = new Vector3(x, y, -10f);
    }
}
