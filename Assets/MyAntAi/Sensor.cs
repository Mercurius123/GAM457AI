using System.Collections;
using System.Collections.Generic;
using Anthill.AI;
using Tanks;
using UnityEngine;


public enum AntAIScenario
{
    InSightRange = 0,
    InAttackRange = 1,
    damagePlayer = 2
}

public class Sensor : MonoBehaviour, ISense
{
    // HACK. Directly dragged, you SHOULD use Physics.SphereOverlap/OnTriggerEnter etc
    public GameObject potentialFriend;
    public bool InAttackRange = false;
    

    public void CollectConditions(AntAIAgent aAgent, AntAICondition aWorldState)
    {       
        aWorldState.Set(AntAIScenario.InSightRange, CheckCanSee());
        aWorldState.Set(AntAIScenario.InAttackRange, InAttackRange);
        aWorldState.Set(AntAIScenario.damagePlayer, CheckIsCloseToPotentialFriend());
    }

    public bool CheckCanSee()
    {
        // I CAN see the guy
        RaycastHit info = new RaycastHit();
        if (Physics.Linecast(transform.position, potentialFriend.transform.position, out info))
        {
            if (info.transform == potentialFriend.transform)
            {
                // I saw the guy!!!
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    }



    public bool CheckIsCloseToPotentialFriend()
    {
        if (Vector3.Distance(transform.position, potentialFriend.transform.position) < 5f)
        {          
            return true;
        }
        else
        {
            return false;
        }
    }

}
