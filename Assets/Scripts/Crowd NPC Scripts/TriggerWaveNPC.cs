using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWaveNPC : MonoBehaviour
{
    public Animator CrowdAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CrowdAnimator.SetBool("Wave", true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CrowdAnimator.SetBool("Wave", false);
        }

    }
}
