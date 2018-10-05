using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingLevel : MonoBehaviour {
    //Di attach ke button yg relevan
	public GameObject button;
	private int unlock;
	public int LevelID;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("ULevels") == 0) {
			PlayerPrefs.SetInt ("ULevels", 1);
		}
		unlock = PlayerPrefs.GetInt ("ULevels");
        if (unlock < LevelID)
        {
            button.SetActive(false);
        }
        else if (unlock >= LevelID)
        {
            button.SetActive(true);
        }
    }
	
}