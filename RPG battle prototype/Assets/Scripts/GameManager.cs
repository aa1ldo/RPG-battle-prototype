using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private AudioSource battleMusicSource, menuMusicSource, effectsSource;

    public bool BattleOver { get; set; }
    public bool YouWin { get; set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }

    public void PlayMusic(string name)
    {
        if(name == "Battle")
        {
            battleMusicSource.Play();
        }
        else if(name == "MainMenu")
        {
            menuMusicSource.Play();
        }
    }

    public void PauseMusic(string name, string ps)
    {
        if (ps == "pause")
        {
            if (name == "Battle")
                battleMusicSource.Pause();
            else if (name == "MainMenu")
                menuMusicSource.Pause();
        }
        else if (ps == "stop")
        {
            if (name == "Battle")
                battleMusicSource.Stop();
            else if (name == "MainMenu")
                menuMusicSource.Stop();
        }
    }

    
    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }
    
}