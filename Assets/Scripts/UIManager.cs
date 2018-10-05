using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public  GameObject sfxon, sfxoff, bmon, bmoff, pauseMenu;
    
    /*private void Awake()
    {
        sfxon = GameObject.Find("sfxon");
        sfxoff = GameObject.Find("sfxoff");
        bmon = GameObject.Find("bmon");
        bmoff = GameObject.Find("bmoff");
    }*/
	private void Start(){
		//checks or unchecks the SFX and Music Buttons
		if(bmon&&bmoff&&sfxon&&sfxoff){
			if(BackMusic.instance.source.mute){bmon.SetActive(false);bmoff.SetActive(true);}else{bmon.SetActive(true);bmoff.SetActive(false);}
			if (SFX.instance.source.mute) {sfxon.SetActive (false);	sfxoff.SetActive (true);} else {sfxon.SetActive(true);sfxoff.SetActive(false);}
		}
	}
	public void resetPrefs(){
		PlayerPrefs.SetInt("IntroDone",0);
		PlayerPrefs.SetInt("ULevels",0);
	}
    public void CloseGame()
    {
        Application.Quit();
    }

    public void SelectLevelMenu()
    {
        if (PlayerPrefs.GetInt("IntroDone") < 1) { SceneManager.LoadScene("IntroComic"); }
        else { SceneManager.LoadScene("SelectLevel"); }
    }
	public void closePause()
	{
		//endPauseHere
		pauseMenu.SetActive(false);
	}
    public void GoToOptions()
    {
        SceneManager.LoadScene("OptionMenu");
    }
    public void Level0()
    {
        SceneManager.LoadScene("Level00");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level01");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level02");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level03");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level04");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level05");
    }
	public void Level6()
	{
		SceneManager.LoadScene("Level06");
	}
	public void Level7()
	{
		SceneManager.LoadScene("Level07");
	}
    public void LevelSecret()
    {
        SceneManager.LoadScene("LevelHard");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
	public void GoToCredits()
	{
		SceneManager.LoadScene("CreditsMenu");
	}
    public void PlayIntro()
    {
        SceneManager.LoadScene("IntroComic");
    }
    public void OnSFX()
    {
        sfxon.SetActive(true);
        sfxoff.SetActive(false);

        SFX.instance.source.mute = false;
    }

    public void OffSFX()
    {
        sfxon.SetActive(false);
        sfxoff.SetActive(true);

        SFX.instance.source.mute = true;
    }

    public void OnBM()
    {
        bmon.SetActive(true);
        bmoff.SetActive(false);

        BackMusic.instance.source.mute = false;

    }

    public void OffBM()
    {
        bmon.SetActive(false);
        bmoff.SetActive(true);

        BackMusic.instance.source.mute = true;
    }
}

