using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1DirectionAttack : MonoBehaviour {

    public Enemy1Direction enemy;

    //public bool isRight = false;

    void Awake()
    {
        enemy = gameObject.GetComponentInParent<Enemy1Direction>();
    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {

            enemy.Attack();

        }

    }
	void OnTriggerExit2D(Collider2D col)
	{

		if (col.gameObject.tag == "Player")
		{

			enemy.Idle();

		}

	}
}
