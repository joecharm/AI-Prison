using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioMattPhone : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("MattPhone")]
    public void MattPhone()
    {
        audioSource.Play();
    }
}
