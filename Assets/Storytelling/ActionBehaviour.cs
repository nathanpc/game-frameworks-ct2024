using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling
{
    public class ActionBehaviour : MonoBehaviour
    {
        [Header("Debug")]
        public bool logWhenPerformed = false;
        
        public virtual void Act()
        {
            if (logWhenPerformed)
            {
                Debug.Log(name + " action was performed");
            }
        }
    }
}
