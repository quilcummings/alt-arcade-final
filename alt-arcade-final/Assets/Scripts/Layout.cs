using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layout : MonoBehaviour
{
    public GameObject player;
    public GameObject bg;
    public GameObject cow;
    public GameObject truck;
   
    public float offset = 19.5f;
    private int count = 1;
    
    void Update()
    {
        if (player.transform.position.x > offset -19.5)
        {
            GameObject background = Instantiate(bg, new Vector3(offset, 0, 0), Quaternion.identity);
            count++;
            if (count % 2 == 0)
            {
                background.transform.Rotate(0, 180, 0);
            }
            
            float cowOff = offset + Random.Range(-10f, 10f);
            Instantiate(cow, new Vector3(cowOff, -3, 0), Quaternion.identity);
            float truckOff = offset + Random.Range(-10f, 10f);
            Instantiate(truck, new Vector3(truckOff, -3, 0), Quaternion.identity);
            offset += 19.5f;
        }
    }
}
