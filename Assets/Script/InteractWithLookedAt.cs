﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects when the player pressed the interact button while looking at the IInteractive,
/// and then calls that IInteracctive's Interact With method.
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    [SerializeField]
    private DetectLookAtInteractive detectLookAtInteractive;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && detectLookAtInteractive.LookedAtInteractive !=null)
        {
            Debug.Log("Player pressed the interact button.");
            detectLookAtInteractive.LookedAtInteractive.InteractWith();
        }
    }
}
