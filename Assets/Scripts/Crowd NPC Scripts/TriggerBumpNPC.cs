using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBumpNPC : MonoBehaviour
{
    // The animator on the NPC model
    public Animator CrowdAnimator;
    private int count = 0;

    // On trigger enter of the collider
    private void OnTriggerEnter(Collider other)
    {
        // if the tag of the collider does not include Player
        if(other.CompareTag("Player"))
        {

            // iterate on count to track number of times of collision
            count++;

            // if count is greater than 2, set throw punch to True
            if(count > 2)
            {
                CrowdAnimator.SetBool("ThrowPunch", true);
            }

            // Set the boolean to true which triggers the TriggerBumpNPC (causing the angry animation) - only triggers when punch is not thrown
            if (CrowdAnimator.GetBool("ThrowPunch") == false)
            {
                CrowdAnimator.SetBool("TriggerBumpNPC", true);
            }

        }
        
    }

    // When the player leaves the collider
    private void OnTriggerExit(Collider other)
    {
        // if the tag of the collider does not include Player
        if (other.CompareTag("Player"))
        {
            // Stop the animation that was triggered above
            CrowdAnimator.SetBool("TriggerBumpNPC", false);
            CrowdAnimator.SetBool("ThrowPunch", false);
        }

    }
}
