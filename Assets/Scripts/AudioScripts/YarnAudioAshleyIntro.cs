using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioAshleyIntro : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("AshleyIntro")]
    public void AshleyIntro()
    {
        audioSource.Play();
    }
}
