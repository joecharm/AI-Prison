using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioGuardSure : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("GuardSure")]
    public void GuardSure()
    {
        audioSource.Play();
    }
}
