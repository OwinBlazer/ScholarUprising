using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMusic : MonoBehaviour {

    public AudioSource source;
    public static BackMusic instance;
    public int audioID = 0;
    public AudioClip[] BgmClip;

    /*
     if (audioID != 3) { BackMusic.instance.source.Stop(); }
        if (!BackMusic.instance.source.isPlaying) { BackMusic.instance.audioID = 3; BackMusic.instance.PlayMusic(BgmClip); }
         */
    /*Audio ID List:
     * 0 = no audio
     * 1 = Menu Music
     * 2 = Intro
     * 3 = Level
     * Every time BackMusic plays an audio, AUDIO ID MUST BE UPDATED MANUALLY<=====================================================!!!!!!!!
     * */
     private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        switch(scene.name)
        {
            //kalau beda, ganti Kalau sama, biarkan jalan
            case "MainMenu":
                if (audioID != 1) { source.Stop(); audioID = 1; PlayMusic(BgmClip[1]); }
                break;
            case "SelectLevel":
                if (audioID != 1) { source.Stop(); audioID = 1; PlayMusic(BgmClip[1]); }
                break;
            case "OptionMenu":
                if (audioID != 1) { source.Stop(); audioID = 1; PlayMusic(BgmClip[1]); }
                break;
            case "Intro":
                if (audioID != 1) { source.Stop(); audioID = 1; PlayMusic(BgmClip[1]); }
                break;
            case "Level00":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level01":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level02":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level03":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level04":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level05":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level06":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
            case "Level07":
                if (audioID != 3) { source.Stop(); audioID = 3; PlayMusic(BgmClip[3]); }
                break;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }

    // klw mau panggil music di scipt laen kaya gini :
    //BackMusic.instance.PlayMusic(masukin variable clip music loe);
}
