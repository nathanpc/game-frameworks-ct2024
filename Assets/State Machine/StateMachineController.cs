using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public class StateMachineController : MonoBehaviour
    {
        public List<State> validStates;
        public State initialState;
        public bool isRunning = true;
        public State currentState = null;
        
        // Start is called before the first frame update
        void Start()
        {
            // Check for required assignments from the user.
            if (validStates == null)
            {
                Debug.LogError("You forgot to assign valid states to the " +
                               "state machine. Please assign them in the Inspector.");
            }
            if (initialState == null)
            {
                Debug.LogError("You forgot to assign an initial state to the " +
                               "state machine. Please assign one in the Inspector.");
            }
            
            // Set the controller for every valid state.
            foreach (var state in validStates)
            {
                state.SetController(this);
            }
            /* This is equivalent to the thing up here ^
            for (int i = 0; i < validStates.Count; i++)
            {
                var state = validStates[i];
                state.SetController(this);
            }
            */

            // Transition into our initial state.
            TransitionTo(initialState);
        }

        private void FixedUpdate()
        {
            // Check if we should not be running and escape immediately.
            if (!isRunning)
                return;
            
            // Execute the running state and check for possible transitions.
            currentState.Running();
            currentState.CheckTransitionCondition();
        }

        /// <summary>
        /// Transitions the state machine to another state.
        /// </summary>
        /// <param name="nextState">Next state to transition to.</param>
        public void TransitionTo(State nextState)
        {
            if (currentState != null)
                currentState.OnExit();
            nextState.OnEnter();
            currentState = nextState;
        }
    }
}

