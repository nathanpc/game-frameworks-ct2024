using System;
using StateMachine;
using UnityEngine;

public class GoState : State
{
    public GameObject light;
    public Material onMaterial;
    public Material offMaterial;
    public int timerSeconds;

    [Header("Possible Transition States")]
    public State warningState;
    
    private int timer = 0;

    public override void OnEnter()
    {
        light.GetComponent<Renderer>().material = onMaterial;
        timer = 0;
    }

    public override void Running()
    {
        timer++;
    }

    public override void OnExit()
    {
        light.GetComponent<Renderer>().material = offMaterial;
    }

    public override void CheckTransitionCondition()
    {
        // Check if time's up.
        if ((timer / 50) >= timerSeconds)
        {
            controller.TransitionTo(warningState);
        }
    }
}
