using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public GameObject ghost;
    public GameObject laser;
    public GameObject Player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ammoText;

    // Start is called before the first frame update
    void Start()
    {
     
      
        
    }

    // Update is called once per frame
    void Update()
    {
       int frame = Time.frameCount;
        if(frame % 70 == 0)
        {
        int i = Random.Range(-4, 5);
        Instantiate(ghost, new Vector3(i,2,-1), Quaternion.identity );
        }

        LaserSpawn();
        AmmoText();
        ScoreText();

    }


    public void LaserSpawn(){ 

     int ax = GameObject.Find("Laser").GetComponent<LaserScript>().AmmoCounter();

        if(ax > 0)
        {
           if(Input.GetKeyDown("space") == true)
           {
            Instantiate(laser, new Vector3(GameObject.FindWithTag("Player").transform.position.x,GameObject.FindWithTag("Player").transform.position.y,GameObject.FindWithTag("Player").transform.position.z), Quaternion.identity );
           }
        }
    }


    public void AmmoText()
    {
       int ammocont = GameObject.Find("Laser").GetComponent<LaserScript>().AmmoCounter();
       ammoText.text = "Ammo:" + ammocont.ToString();
    }

    public void ScoreText()
    {
        int scorecont =  GameObject.Find("Balloon_Ghost(Mixed)").GetComponent<GhostScript>().ScoreCounter();
        scoreText.text = "Score:" + scorecont.ToString();      
    }



}
