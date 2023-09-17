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
            // ���� ���� �� �������������, ������ ������������ ������ �����������
            source.clip = sound[0];
            source.Play();
            isPlaying = true;
        }
        else
        {
            // ���� ���� �������������, ���������� ���������������
            source.Stop();
            isPlaying = false;
        }
    }
}
