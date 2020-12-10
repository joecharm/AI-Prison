using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioGuardIntro : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("GuardIntro")]
    public void GuardIntro()
    {
        audioSource.Play();
    }
}
