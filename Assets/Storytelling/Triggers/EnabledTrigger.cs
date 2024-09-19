using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling.Triggers
{
    /// <summary>
    /// Triggers actions whenever the associated component has been enabled.
    /// </summary>
    public class EnabledTrigger : TriggerBehaviour
    {
        private void FixedUpdate()
        {
            CheckTriggered();
        }

        public override void CheckTriggered()
        {
            if (this.enabled)
            {
                PerformAllActions();
            }
        }
    }
}
