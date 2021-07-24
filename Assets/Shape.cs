using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    Vector3 position = new Vector3(0,1000,224);
    Vector3 scale = new Vector3(100,100,100);
    // Start is called before the first frame update

    private float speed;
    void Start()
    {  
        //transform.position = position;
        transform.localScale = scale;
        GameObject camera = GameObject.Find("Main Camera");
        ShapeGenerator shape = camera.GetComponent<ShapeGenerator>(); //gets the shapes fallspeed from shape generator script
        speed = shape.fallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 700) //checks if shape is at bottom then deletes itself
        {
            Destroy (gameObject);
        }
       transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z); //decreases its y position
    }
}
