using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript_Gen : MonoBehaviour {
    public GameObject Hero;
	// Use this for initialization
	void Start () {
        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Attack")
        {
            Hero.SendMessage("airHang");
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.SendMessage("stagger", 0.5f);
        }
    }
}
