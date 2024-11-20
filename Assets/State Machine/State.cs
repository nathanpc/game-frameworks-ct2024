using UnityEngine;

namespace StateMachine
{
    /// <summary>
    /// Base class of every state in a state machine.
    /// </summary>
    public abstract class State : MonoBehaviour
    {
        protected StateMachineController controller = null;
        
        /// <summary>
        /// Method that's called once whenever we transition into this state.
        /// </summary>
        public virtual void OnEnter() {}
        
        /// <summary>
        /// Called every FixedUpdate while the state machine is in this state.
        /// </summary>
        public virtual void Running() {}
        
        /// <summary>
        /// Called once whenever we are out of this state and into another.
        /// </summary>
        public virtual void OnExit() {}

        /// <summary>
        /// Check for conditions to transition from this state and into another.
        /// </summary>
        public abstract void CheckTransitionCondition();

        /// <summary>
        /// Sets the state machine controller associated with this state.
        /// </summary>
        /// <param name="controller">The associated state machine controller</param>
        public void SetController(StateMachineController controller)
        {
            this.controller = controller;
        }
    }
}
