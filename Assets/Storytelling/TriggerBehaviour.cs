using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling
{
    /// <summary>
    /// The base component for a trigger. DO NOT USE THIS DIRECTLY.
    /// </summary>
    public class TriggerBehaviour : MonoBehaviour
    {
        [SerializeField]
        protected List<ActionBehaviour> actions;
        [SerializeField]
        protected GameObject initiator = null;

        [Header("Debug")] public bool logWhenTriggered = false;

        /// <summary>
        /// The method that actually checks if this trigger was triggered.
        /// </summary>
        public virtual void CheckTriggered()
        {
            // You are supposed to fill this in in another class.
        }

        /// <summary>
        /// The method called to perform all actions associated with this trigger.
        /// </summary>
        protected void PerformAllActions()
        {
            if (logWhenTriggered)
            {
                if (initiator == null)
                {
                    Debug.Log(name + " trigger was triggered");
                }
                else
                {
                    Debug.Log(name + " trigger was triggered by " +
                              initiator.name);
                }
            }
            
            foreach (ActionBehaviour action in actions)
            {
                action.Act();
            }
        }
    }
}
