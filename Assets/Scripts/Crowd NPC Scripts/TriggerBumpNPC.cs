using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBumpNPC : MonoBehaviour
{
    // The animator on the NPC model
    public Animator CrowdAnimator;
    private int count = 0;
    private bool hasPunched = false;

    // On trigger enter of the collider
    private void OnTriggerEnter(Collider other)
    {
        // if the tag of the collider does not include Player
        if(other.CompareTag("Player"))
        {
            // trigger the bumped angry animation 
            CrowdAnimator.SetTrigger("TriggerBumpNPC");

            // iterate on count to track number of times of collision
            count++;

            // if count is greater than 2, set throw punch to True
            if(count > 2)
            {
                // if the player has not been punched
                if(hasPunched == false)
                {
                    CrowdAnimator.SetTrigger("ThrowPunch");
                    // set bool hasPunched to true
                    hasPunched = true;
                }
                
            }
        }
        
    }

}
