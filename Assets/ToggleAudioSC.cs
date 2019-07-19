using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAudioSC : MonoBehaviour {


    public AudioClip true_audio;
    public AudioClip false_audio;
    public AudioClip event_audio;
    public AudioClip gameClear_audio;
    public AudioClip gameOver_audio;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void OnValueChanged(Toggle tgl)
    {
        if (tgl.isOn == true)
        {
            audioSource.clip = true_audio;
            audioSource.Play();
        }
        else
        {
            audioSource.clip = false_audio;
            audioSource.Play();
        }
    }

    public void EventPlayAudio()
    {
        audioSource.clip = event_audio;
        audioSource.Play();
    }

    public void GameClearAudio()
    {
        audioSource.clip = gameClear_audio;
        audioSource.Play();
    }
    public void GameOverAudio()
    {
        audioSource.clip = gameOver_audio;
        audioSource.Play();
    }
}
