using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiVision : MonoBehaviour
{
    public float radius;
    public float angle;

    public GameObject playerRef;

    public LayerMask targerMask;
    public LayerMask obstructionMask;

    public bool canSeePlayer;

    private void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    private IEnumerator FOVRoutine()
    {
        float delay = 0.2f;
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {

        }


    }
}
