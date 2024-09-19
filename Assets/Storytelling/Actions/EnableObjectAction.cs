using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Storytelling.Actions
{
    /// <summary>
    /// Action used to enable GameObjects in a scene.
    /// </summary>
    public class EnableObjectAction : ActionBehaviour
    {
        public List<GameObject> objectsToEnable;

        public override void Act()
        {
            base.Act();
            foreach (GameObject obj in objectsToEnable)
            {
                obj.SetActive(true);
            }
        }
    }
}
