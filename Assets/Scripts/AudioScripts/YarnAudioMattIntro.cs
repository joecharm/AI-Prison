using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioMattIntro: MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("MattIntro")]
    public void MattIntro()
    {
        audioSource.Play();
    }
}
