using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehavior : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform[] targets;
    public Transform targetAux;
    private int targetActual = 0;


    // Start is called before the first frame update
    void Start()
    {
        targetAux = target;
        agent.destination = targetAux.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (agent.hasPath && agent.remainingDistance < 1)
        {
            if(targetAux == target)
            {
                targetAux = target2;
            }
            else
            {
                targetAux = target;
            }
            agent.destination = targetAux.position;
        }
    }
}
