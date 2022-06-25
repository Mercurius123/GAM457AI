using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBehaviourTree : MonoBehaviour
{
    public bool CanSeePlayer = false;
    public bool PlayerinRange = false;
    
    public void idle()
    {
        Debug.Log("Idle");
    }
    public void Chase()
    {
        Debug.Log("Chase");
    }
    public void Attack()
    {
        Debug.Log("Attack");
    }

    public bool ReturnsABool()
    {
        return true;
    }

}
