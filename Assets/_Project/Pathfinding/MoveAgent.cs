using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
    public NavMeshAgent agent; // Reference to the NavMeshAgent component
    public Vector3 destination = new Vector3(17.0486183f, 1.90734863e-06f, -4.96769142f); // Target position

    void Update()
    {
        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }

        if (agent != null)
        {
            agent.SetDestination(destination); // Set the agent's destination to the target position
        }
        else
        {
            Debug.LogError("NavMeshAgent component is missing on the game object.");
        }
    }
}
