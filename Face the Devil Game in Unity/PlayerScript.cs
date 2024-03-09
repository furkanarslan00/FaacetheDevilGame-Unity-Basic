using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

   // Start is called before the first frame update
   void Start()
   {   
     

   }

   // Update is called once per frame
   void Update()
   {
       
      float h = Input.GetAxisRaw("Horizontal"); 
      Rigidbody rb = gameObject.GetComponent<Rigidbody>();
      rb.velocity = new Vector3(h*-4,0,0);

    }

    
   void OnTriggerEnter(Collider other)
   {
    Time.timeScale = 0;
      
   }
   

   
}
    



    

