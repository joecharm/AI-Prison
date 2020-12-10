using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioPeteIntro : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("PeteIntro")]
    public void PeteIntro()
    {
        audioSource.Play();
    }
}
