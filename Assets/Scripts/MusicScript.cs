using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {

    public bool musicStart = false;
    public GameObject musicPlayer;
    public AudioSource music;

    public void Awake()
    {
        if (!musicStart)
        {
            music.Play();
            DontDestroyOnLoad(musicPlayer);
            musicStart = true;
        }
        else
        {
            Destroy(musicPlayer);
        }
    }

    
}
