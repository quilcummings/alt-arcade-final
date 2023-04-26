using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "UFO")
        {
            this.gameObject.SetActive(false);
            RayCast.Instance.caught = false;
        }
    }
}
