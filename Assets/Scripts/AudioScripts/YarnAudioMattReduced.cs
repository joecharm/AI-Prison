using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioMattReduced : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("MattReduced")]
    public void MattReduced()
    {
        audioSource.Play();
    }
}
