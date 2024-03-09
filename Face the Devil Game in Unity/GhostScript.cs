using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{ 
  public static int Score = 0;

  // Start is called before the first frame update
  void Start() 
  {       
  Rigidbody rb = gameObject.GetComponent<Rigidbody>();
  rb.velocity = new Vector3(0,0,2);    
  }

  // Update is called once per frame
  void Update()
  {
       
  }

    
  void OnTriggerEnter(Collider other)
  {       
    Score = Score + 100;
    Destroy( gameObject );
  }

  public int ScoreCounter()
  {
    return Score;
  }

}