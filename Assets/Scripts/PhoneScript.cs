using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PhoneScript : MonoBehaviour {
    private int unlocking;
	public AudioClip sounds;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="Player")
        {
			
			if (SFX.instance) { SFX.instance.source.PlayOneShot(sounds); }
            Scene scene = SceneManager.GetActiveScene();
            switch (scene.name)
            {
			case "Level00":
				unlocking = 2;
					if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level01");
                    break;
                case "Level01":
                    unlocking = 3;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level02");
                    break;
                case "Level02":
                    unlocking = 4;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level03");
                    break;
                case "Level03":
                    unlocking = 5;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level04");
                    break;
                case "Level04":
                    unlocking = 6;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level05");
                    break;
                case "Level05":
                    unlocking = 7;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level06");
                    break;
                case "Level06":
                    unlocking = 8;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("Level07");
                    break;
                case "Level07":
                    unlocking = 9;
				if (unlocking > PlayerPrefs.GetInt ("ULevels")) {PlayerPrefs.SetInt("ULevels", unlocking);}
                    SceneManager.LoadScene("SceneEndDemo");
                    break;
            }
            
        }
    }
}
