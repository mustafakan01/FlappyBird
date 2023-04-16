using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move_Boru : MonoBehaviour
{
    public float speed;
   

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed* Time.deltaTime;
    }
}
