﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    private ActionBasedController _controller;
    public Hand hand;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        hand.SetGrip(_controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(_controller.activateAction.action.ReadValue<float>());
    }
}
