using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleter : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
      
  }

  void OnTriggerEnter2D(Collider2D coll)
  {
    Debug.Log(coll.gameObject.name);
    if (coll.gameObject.CompareTag("Pipe")) {
      Destroy(coll.gameObject.transform.parent.gameObject);
    }
    Debug.Log("GameObject1 collided with " + coll.gameObject);
  }

}
