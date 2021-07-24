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

    private int count;

    private float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        timeTill = Random.Range(minTime, maxTime); //creates the time between when the next shape can spawn
    }


    void InstantiateShape()
    {
        int xPos = Random.Range(-670, 510);
        Instantiate(myPrefab, new Vector3(xPos,1200,224), Quaternion.identity);
        timeTill = Random.Range(minTime, maxTime);
        currentTime = 0;
    }


    // Update is called once per frame
    void Update()
    {
         currentTime += Time.deltaTime;
        if(currentTime > timeTill)
        {
            InstantiateShape();
            count++;
            if(count % 10 == 0)
            {
                fallSpeed += 0.3f;
            }
        }

    }
}
