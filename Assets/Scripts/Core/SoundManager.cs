using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance
    { 
        get; 
        private set;
    }

    private AudioSource soundSource;
    private AudioSource musicSource;

    private void Awake()
    {

        soundSource = GetComponent<AudioSource>();
        musicSource = transform.GetChild(0).GetComponent<AudioSource>();

        //Keep this object even when we go to new scene
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        //Destroy duplicate gameobjects
        else if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        ChangeMusicVolume(0);
        ChangeSoundVolume(0);
    }

    public void PlaySound(AudioClip _sound)
    {
        soundSource.PlayOneShot(_sound);
    }

    public void ChangeSoundVolume(float _change)
    {

        ChangeSourceVolume(1, "soundVolume", _change, soundSource );

        /*
        float baseVolume = 1;

        float currentVolume = PlayerPrefs.GetFloat("soundVolume", 1);
        currentVolume += _change;

        if(currentVolume > 1)
        {
            currentVolume = 0;
        }
        else if(currentVolume < 0)
        {
            currentVolume = 1;
        }

        float finalVolume = currentVolume * baseVolume;
        soundSource.volume = finalVolume;

        PlayerPrefs.SetFloat("soundVolume", currentVolume);*/
    }


    public void ChangeMusicVolume(float _change)
    {    

        ChangeSourceVolume(0.3f, "musicVolume", _change, musicSource );
    /*
        float baseVolume = 0.3f;

        float currentVolume = PlayerPrefs.GetFloat("musicVolume", 1);
        currentVolume += _change;

        if(currentVolume > 1)
        {
            currentVolume = 0;
        }
        else if(currentVolume < 0)
        {
            currentVolume = 1;
        }

        float finalVolume = currentVolume * baseVolume;
        musicSource.volume = finalVolume;

        PlayerPrefs.SetFloat("musicVolume", currentVolume);
        */
    }

    private void ChangeSourceVolume(float baseVolume, string volumeName, float change, AudioSource source)
    {
        float currentVolume = PlayerPrefs.GetFloat(volumeName, 1);
        currentVolume += change;

        if(currentVolume > 1)
        {
            currentVolume = 0;
        }
        else if(currentVolume < 0)
        {
            currentVolume = 1;
        }

        float finalVolume = currentVolume * baseVolume;
        source.volume = finalVolume;

        PlayerPrefs.SetFloat(volumeName, currentVolume);
    }

}