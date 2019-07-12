using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MoveToClickPoint : MonoBehaviour
{
    private NavMeshAgent _Agent;

    private Camera _Camera;

    private void Awake()
    {
        _Agent = GetComponent<NavMeshAgent>();
        _Camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                _Agent.SetDestination(hit.point);
            }
        }
    }
}