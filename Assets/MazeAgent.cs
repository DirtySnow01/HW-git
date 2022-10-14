using UnityEngine;
using UnityEngine.AI;

public class MazeAgent : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _agent.destination = Target.position;
    }
}
