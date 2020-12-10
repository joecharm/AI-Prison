using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioMattAshley : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("MattAshley")]
    public void MattAshley()
    {
        audioSource.Play();
    }
}
