using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;
    public AudioSource switchAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        AudioSource sfxInstance = Instantiate(sfxAudioSource);
        sfxInstance.transform.position = spawnPosition;
        sfxInstance.Play();
    }

    public void PlaySwitchSFX(Vector3 spawnPosition)
    {
        AudioSource sfxIns = Instantiate(switchAudioSource);
        sfxIns.transform.position = spawnPosition;
        sfxIns.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
