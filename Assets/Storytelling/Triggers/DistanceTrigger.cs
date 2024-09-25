using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling.Triggers
{
    /// <summary>
    /// Triggers actions based on the distance of the player from the
    /// attached GameObject.
    /// </summary>
    public class DistanceTrigger : TriggerBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
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
