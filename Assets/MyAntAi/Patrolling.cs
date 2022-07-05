using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Anthill.AI;

public class Patrolling : AntAIState
{
    public float speed = 100;

    public GameObject maingameObject;

    public override void Create(GameObject aGameObject)
    {
        base.Create(aGameObject);

        maingameObject = aGameObject;
    }

    public override void Execute(float aDeltaTime, float aTimeScale)
    {
        base.Execute(aDeltaTime, aTimeScale);

        // maingameObject.GetComponent<Rigidbody>().AddForce(new Vector3(x:Random.Range)(-speed. speed), y:0, z:Random.Range(-speed, speed));
    }
}
