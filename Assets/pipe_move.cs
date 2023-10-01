using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_move : MonoBehaviour
{
    public float moveSpeed = 1;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
