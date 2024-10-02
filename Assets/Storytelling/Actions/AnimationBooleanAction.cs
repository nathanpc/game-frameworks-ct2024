using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling.Actions
{
    /// <summary>
    /// Sets the boolean of an animator whenever needed.
    /// </summary>
    public class AnimationBooleanAction : ActionBehaviour
    {
        public Animator animator;
        public string parameterName;
        public bool value;

        public override void Act()
        {
            base.Act();
            animator.SetBool(parameterName, value);
        }
    }
}
