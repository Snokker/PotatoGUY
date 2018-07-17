using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoGuy : MonoBehaviour
{

    //members
    public float speed = 1.5f;
    public Sprite[] array;
    private SpriteRenderer sr;
    int teller = 0;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
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
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            sr.flipX = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            sr.flipY = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            sr.flipY = true;
        }
    }
    void Schieten()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SchietAnimatie();
        }
    }

    void SchietAnimatie()
    {
        if (teller < 5)
        {
            sr.sprite = array[0];
        }
        else
        {
            sr.sprite = array[1];
        }
        teller++;

        if (teller > 10)
        {
            teller = 0;
        }
    }
}
