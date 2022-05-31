using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiGuy : MonoBehaviour
{
    public List<AiGuy> otherAIGuys;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Example loop through all
        foreach (AiGuy otherAIGuy in otherAIGuys)
        {

        }
    }
}
