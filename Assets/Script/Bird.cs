using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    
    public float velocity = 1f;
    public Rigidbody2D rb2;


    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            rb2.velocity = Vector2.up * velocity;//sýçrama        
        }


    }
}
