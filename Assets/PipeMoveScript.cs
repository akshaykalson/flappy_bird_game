using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    public float deadZone = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;  // multiplied by delta time so that FPS doesn't affect the movespeed
        
        if (transform.position.x< deadZone)
        {

            Destroy(gameObject);


        }

    }
}
