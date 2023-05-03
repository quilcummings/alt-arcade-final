using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RayCast : MonoBehaviour
{
    public static RayCast Instance;
    
    private float step; 
    public bool caught = false;
    public bool trash = false;

    private GameObject cow;
    private GameObject truck;

    public GameObject lifeOne;
    public GameObject lifeTwo;
    public GameObject lifeThree;
    
    
    private int cowsAbducted;
    private int trucksAbducted;
    public TMP_Text cowsText;
    public GameObject gameOver;

    public AudioSource sound;
    public AudioClip sou;

    void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if (trucksAbducted == 1)
        {
            lifeThree.SetActive(false);
        }
        else if (trucksAbducted == 2)
        {
            lifeTwo.SetActive(false);
        }
        else if (trucksAbducted == 3)
        {
            lifeOne.SetActive(false);
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down*10);
        Debug.DrawRay(transform.position, Vector2.down*10);

        RaycastHit2D hitRange = Physics2D.CircleCast(transform.position, 100f, Vector2.down*10);
        
        if (hit.collider.gameObject.tag == "Cow" && Input.GetKey(KeyCode.X))
        {
            caught = true;
            cow = hit.collider.gameObject;
        }
        if (caught)
        {
            if (!sound.isPlaying)
            {
                sound.PlayOneShot(sou);
            }

            step = 10 * Time.deltaTime;
            cow.transform.position = Vector2.MoveTowards(cow.transform.position, transform.position, step);
        }
        
        if (hit.collider.gameObject.tag == "Truck" && Input.GetKey(KeyCode.X))
        {
            trash = true;
            truck = hit.collider.gameObject;
        }
        if (trash)
        {
            if (!sound.isPlaying)
            {
                sound.PlayOneShot(sou);
            }
            
            step = 10 * Time.deltaTime;
            truck.transform.position = Vector2.MoveTowards(truck.transform.position, transform.position, step);
        }
        
        Debug.Log(cowsAbducted);
        cowsText.text = "Cows: " + cowsAbducted.ToString();
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Cow")
        {
            cowsAbducted++;
        }
        if (col.gameObject.tag == "Truck")
        {
            trucksAbducted++;
        }
    }
}
