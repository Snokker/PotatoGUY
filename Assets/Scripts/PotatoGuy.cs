using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoGuy : MonoBehaviour {

    //members
    public float speed = 1.5f;
    public Sprite[] array;
    private SpriteRenderer sr;

    // Use this for initialization
    void Start ()
    {
        sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
     void Update ()
     {
        Movement();
        Schieten();
     }

    //beweging voor potatoguy, deze moet nog aangepast worden
    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    void Schieten()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Schietanimatie(); 
        }
    }

    void Schietanimatie()
    {
        int teller = 0;
        for (teller; teller < 2; teller++)
        {
            sr.sprite = array[teller];
        }
    }
 }
