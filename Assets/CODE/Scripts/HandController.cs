using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    ActionBasedController controller;
    public HandSoggy handSoggy; // Calls Hand class 
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        handSoggy.SetGrip(controller.selectAction.action.ReadValue<float>());
        handSoggy.SetScissors(controller.activateAction.action.ReadValue<float>());
    }
}
