using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
	public Rigidbody2D rb;
	public float flapStrength = 11;

	
	void Start()
	{
		gameObject.name = "Bob";
	}

	// Update is called once per frame
	void Update()
	{
			// rb.velocity = Vector2.right * 10;
		if(Input.GetKeyDown(KeyCode.Space)){
			rb.velocity = Vector2.up * flapStrength;
		}
	}
}
