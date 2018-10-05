using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCrumbler : MonoBehaviour {
    public float crumbleTime;
    public float respawnTime;
    private Animator anim;
    public GameObject block;
    private float currTimer;
    private bool crumbleActive;
    private bool delayedSpawn;
    private int order = 0;
	// Use this for initialization
	void Start () {
        currTimer = 0;
        crumbleActive = false;
        delayedSpawn = false;
        anim = block.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        //animation controller
		if(anim.gameObject.activeSelf){if (crumbleActive) { anim.SetBool("Crumbling", true); } else { anim.SetBool("Crumbling", false); }}

        //if activated and smaller than required time, continue timer
        if (crumbleActive && currTimer < crumbleTime)
        {
            currTimer += Time.deltaTime;
        }

        //Debug.Log("Current Before time is " + currTimer + " and activity is " + crumbleActive + " with delayedSpawn of "+delayedSpawn);
        //if activated AND timer is more than required time
        if (currTimer>=crumbleTime&&crumbleActive) {
            //crumble the block
            block.SetActive(false);
            currTimer = 0;
            crumbleActive = false;
            foreach (Collider c in GetComponentsInChildren <Collider>())
            {
                c.enabled = false;
            }
        }

        //if crumbled and is respawning, start currTimer
        if (!block.activeSelf&&currTimer<respawnTime) {
            currTimer += Time.deltaTime;
        }

        //respawn block
        //<<========================================================ONLY RESPAWN IF THERE's NO HERO/PLAYER
        if (currTimer>=respawnTime&&!block.activeSelf)
        {
            if (!delayedSpawn)
            {
                currTimer = 0;
                block.SetActive(true);
                foreach (Collider c in GetComponentsInChildren<Collider>())
                {
                    c.enabled = true;
                }
            }
        }

        
    }
    

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player"&&!delayedSpawn)
        {
            //activate crumbling
            if (block.activeSelf) { crumbleActive = true; }
            //delays spawn in case player is still there
            delayedSpawn = true;
            
            
        }
        

    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        //activate respawn if hero exits
        if (col.tag=="Player") {
        delayedSpawn = false;
            
        }
    }
}
