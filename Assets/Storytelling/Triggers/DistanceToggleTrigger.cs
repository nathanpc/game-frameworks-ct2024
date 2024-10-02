using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling.Triggers
{
    /// <summary>
    /// Triggers actions based on the distance of the player from the
    /// attached GameObject. Whenever the player is outside the trigger
    /// distance it performs another set of actions.
    /// </summary>
    public class DistanceToggleTrigger : TriggerBehaviour
    {
        public List<ActionBehaviour> outOfRangeActions;
        
        public float triggerDistance;
        public int checkDelay = 5;
        private int delayCounter = 0;

        void FixedUpdate()
        {
            if (delayCounter < checkDelay)
            {
                delayCounter++;
                return;
            }

            CheckTriggered();
            delayCounter = 0;
        }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, triggerDistance);
        }
        
        public override void CheckTriggered()
        {
            bool isNear = Vector3.Distance(transform.position, initiator.transform.position)
                          <= triggerDistance;
            if (isNear)
            {
                PerformAllActions();
            }
            else
            {
                PerformOutOfRangeActions();
            }
        }

        /// <summary>
        /// Performs all of the actions related to the player being out of the
        /// range of the trigger. This is a different list of actions from the
        /// main one.
        /// </summary>
        protected void PerformOutOfRangeActions()
        {
            foreach (ActionBehaviour action in outOfRangeActions)
            {
                action.Act();
            }
        }
    }    
}
