using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioGuardWrongPerson : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("GuardWrongPerson")]
    public void GuardWrongPerson()
    {
        audioSource.Play();
    }
}
