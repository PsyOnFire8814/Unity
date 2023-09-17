using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource source;

    private bool isPlaying = false;

    public void ToggleSound()
    {
        if (!isPlaying)
        {
            // Если звук не проигрывается, начать проигрывание первой аудиозаписи
            source.clip = sound[0];
            source.Play();
            isPlaying = true;
        }
        else
        {
            // Если звук проигрывается, остановить воспроизведение
            source.Stop();
            isPlaying = false;
        }
    }
}
