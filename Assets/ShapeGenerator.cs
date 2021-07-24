using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    public GameObject myPrefab;
    public int maxTime = 6;
    public int minTime = 2;
    private float timeTill;
    public float fallSpeed = 0.3f;

    private int count; //counts how many shapes have spawned

    private float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0; 
        timeTill = Random.Range(minTime, maxTime); //creates the time between when the next shape can spawn
    }


    void InstantiateShape()
    {
        int xPos = Random.Range(-670, 510); //chooses random x position to spawn
        Instantiate(myPrefab, new Vector3(xPos,1200,224), Quaternion.identity); //creates the temp prefab object 
        timeTill = Random.Range(minTime, maxTime);
        currentTime = 0; //resets current time counter
    }


    // Update is called once per frame
    void Update()
    {
         currentTime += Time.deltaTime; //updates playtime
        if(currentTime > timeTill) //check if time is up before spawning new shape
        {
            InstantiateShape();
            count++;
            if(count % 10 == 0) //increases the shapes speed every 10 shapes that spawn
            {
                fallSpeed += 0.3f; //the fall speed increase rate
            }
        }

    }
}
