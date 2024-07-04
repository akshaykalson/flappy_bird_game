using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2f; // decides the time at which pipes will originate, more spawnRate = more time between pipe generation
    private float timer = 0;
    public float heightOffset = 5; //decides the height of     
    
    void Start()
    {
        spawnPipe();    }
    
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); //then spawn a new pipe object, if timer is more than spawn rate
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; //just counting up the timer
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }
}
