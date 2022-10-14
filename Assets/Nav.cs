using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentTarget : MonoBehaviour
{
    public Transform Target;

    void start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Target.position;
    }
}
