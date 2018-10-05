using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {
    public float timerPeluru;
    public float intervalPeluru;
	private float rotationValue = 0;
    void Update()
    {
		rotationValue += Time.deltaTime*10;
		if(rotationValue>360){rotationValue -= 360;}
        timerPeluru += Time.deltaTime;
		transform.Rotate (0,0,rotationValue);
        if (timerPeluru >= intervalPeluru)
        {
            Destroy(gameObject);
        }
    }

	void OnTriggerEnter2D(Collider2D col){
		if (!col.isTrigger) {
			if (col.gameObject.tag != "Enemy") {
				Destroy (gameObject);
			}
		}
		if (col.gameObject.tag == "Player")
		{
            col.SendMessage("stagger", 2.3f);
        }
	}
}
