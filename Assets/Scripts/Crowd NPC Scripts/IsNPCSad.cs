using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsNPCSad : MonoBehaviour
{
    // Make the player play a sad idle state at random when idle (50% chance as defined in the animator condition)

    // The Crowd NPC Animator
    public Animator animator;
    // Boolean of if the NPC has been sad before
    private bool hasBeenSad = false;
    // a float chance of the NPC being sad
    private float sadChance;

    private void Start()
    {
        // call the set method
        isNPCSad();
    }

    public void isNPCSad()
    {
        // if the NPC has not been sad before, generate a random num between 0-1.
        if (hasBeenSad == false)
        {
            // generate random number 
            sadChance = Random.Range(0.0f, 1.0f);
            // set the float in the animator parameter
            animator.SetFloat("IsSadChance", sadChance);
            // set hasBeenSad to true
            hasBeenSad = true;
            // set the boolean parameter of hasBeenSad to true
            animator.SetBool("hasBeenSad", true);
            // Play the animator state
            animator.Play("SadIdle");
        }
    }

}
