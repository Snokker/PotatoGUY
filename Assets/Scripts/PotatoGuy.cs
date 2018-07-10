using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoGuy : MonoBehaviour {

    //members
    public float speed = 1.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
     void Update ()
     {
        Movement();
     }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            return;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            return;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            return;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            return;
        }
    }
 }
