using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsNPCOffensiveIdle : MonoBehaviour
{
    // Make the player play a sad idle state at random when idle (50% chance as defined in the animator condition)

    // The Crowd NPC Animator
    public Animator animator;
    // Boolean of if the NPC has been sad before
    private bool hasBeenOffensive = false;
    // a float chance of the NPC being sad
    private float offensiveChance;

    private void Start()
    {
        // call the set method
        isNPCOffensive();
    }

    public void isNPCOffensive()
    {
        // if the NPC has not been sad before, generate a random num between 0-1.
        if (hasBeenOffensive == false)
        {
            // generate random number 
            offensiveChance = Random.Range(0.0f, 1.0f);
            // set the float in the animator parameter
            animator.SetFloat("IsOffensiveChance", offensiveChance);

            // if the sad chance is above 0.5
            if (offensiveChance >= 0.5f)
            {
                // set hasBeenSad to true
                hasBeenOffensive = true;
                // set the boolean parameter of hasBeenSad to true
                animator.SetBool("hasBeenOffensive", true);
                // Play the animator state one time
                animator.Play("OffensiveIdle");
            }

        }
    }

}
