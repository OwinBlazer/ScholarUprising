using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour {
    public GameObject player;
	private int wallCount=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.position= new Vector2(player.transform.position.x, player.transform.position.y);
		if (wallCount < 1) {player.SendMessage("wallExit");	} 
		else {player.SendMessage("wallSlide");}
    }
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Wall")
		{
			wallCount++;
		}

	}
	/*
    private void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "Wall")
        {
            player.SendMessage("wallSlide");
        }
        
    }
    */
    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
			wallCount--;
            //player.SendMessage("wallExit");
        }
    }
}
