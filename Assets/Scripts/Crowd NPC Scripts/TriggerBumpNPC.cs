using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBumpNPC : MonoBehaviour
{
    public Animator CrowdAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CrowdAnimator.SetBool("TriggerBumpNPC", true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CrowdAnimator.SetBool("TriggerBumpNPC", false);
        }

    }
}
