using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnAnimationController : MonoBehaviour
{
    public Animator animationController;

    [YarnCommand("ToggleAnimation")]
    public void ToggleAnimation(string AnimationName)
    {
        animationController.CrossFadeInFixedTime(AnimationName, 0.4f);
    }

}
