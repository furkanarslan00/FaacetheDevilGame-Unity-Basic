using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
     public static int ammo = 2;
    
    // Start is called before the first frame update
    void Start()
    {
       Rigidbody rb = gameObject.GetComponent<Rigidbody>();
       rb.velocity = new Vector3(0,0,-3);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("space") == true )
       {
        ammo--;
       }       
    }

     void OnTriggerEnter(Collider other)
     {
       
        ammo = ammo+2;
        Destroy(gameObject);
         
     }

     public int AmmoCounter()
     {
      return ammo;
     }

          
}

