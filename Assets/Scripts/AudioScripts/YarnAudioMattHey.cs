using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioMattHey : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("MattHey")]
    public void MattHey()
    {
        audioSource.Play();
    }
}
