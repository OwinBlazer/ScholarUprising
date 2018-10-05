using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAllDirection : MonoBehaviour {

	//You can add health here

	//public float distance;
	public float shootInterval;
	public float bulletSpeed = 100;
	public float bulletTimer;

	private Animator anim;
	public GameObject bullet;
	public Transform target;
	public Transform shootPoint;

	public void Start(){
		anim = GetComponent<Animator>();
	}
	public void Idle(){
		bulletTimer = 0;
	}
	public void Attack(){
		bulletTimer += Time.deltaTime;
		if (shootInterval - bulletTimer < 0.5f) {anim.SetBool ("Attacking", true);} else {anim.SetBool ("Attacking", false);}
		if (bulletTimer >= shootInterval) {
			Vector2 direction = target.transform.position - transform.position;
			direction.Normalize ();


			GameObject bulletClone;
			bulletClone = Instantiate (bullet, shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
			bulletClone.GetComponent<Rigidbody2D> ().velocity = direction * bulletSpeed;

			bulletTimer = 0;

			/*if (attackRight) { //assume that the player is on the right
				GameObject bulletClone;
				bulletClone = Instantiate (bullet, shootPointRight.transform.position, shootPointRight.transform.rotation) as GameObject;
				bulletClone.GetComponent<Rigidbody2D> ().velocity = direction * bulletSpeed;

				bulletTimer = 0;
			}*/
		}
	}
}
