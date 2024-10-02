using System.Collections;
using System.Collections.Generic;
using Storytelling;
using UnityEngine;


/// <summary>
/// A rough and ready way of implementing a door opener.
/// </summary>
public class AutoDoorOpener : MonoBehaviour
{
    public float triggerDistance;
    public Animator doorAnimator;
    public GameObject player;
    public int checkDelay = 5;

    private int delayCounter = 0;

    void FixedUpdate()
    {
        if (delayCounter < checkDelay)
        {
            delayCounter++;
            return;
        }

        Act();
        delayCounter = 0;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, triggerDistance);
    }

    void Act()
    {
        doorAnimator.SetBool("IsOpened", CheckPlayerNear());
    }

    /// <summary>
    /// Checks if the player is near to the object this is attached to.
    /// </summary>
    /// <returns>True if the player is within the trigger distance. False otherwise.</returns>
    bool CheckPlayerNear()
    {
        return Vector3.Distance(this.transform.position, player.transform.position)
            <= triggerDistance;
    }
}
