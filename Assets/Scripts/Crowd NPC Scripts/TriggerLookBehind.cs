using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLookBehind : MonoBehaviour
{
    // The animator on the NPC model
    public Animator CrowdAnimator;

    // On trigger enter of the collider
    private void OnTriggerEnter(Collider other)
    {
        // if the tag of the collider does not include Player
        if(other.CompareTag("Player"))
        {
            // set the trigger of look behind which will play the animation based on the condition in the animator
            CrowdAnimator.SetTrigger("LookBehind");

        }
        
    }

}
