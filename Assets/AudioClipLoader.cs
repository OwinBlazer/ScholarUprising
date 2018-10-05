using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioClipLoader : MonoBehaviour {

    public AudioClip BgmClip;

    private void Start()
    {
        if (BackMusic.instance.audioID!=3) { BackMusic.instance.source.Stop(); }
        if (!BackMusic.instance.source.isPlaying) { BackMusic.instance.audioID = 3; BackMusic.instance.PlayMusic(BgmClip); }
        
    }
}
