using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAudioAshleyFriendsWithPete : MonoBehaviour
{
    public AudioSource audioSource;

    [YarnCommand("AshleyFriends")]
    public void AshleyFriends()
    {
        audioSource.Play();
    }
}
