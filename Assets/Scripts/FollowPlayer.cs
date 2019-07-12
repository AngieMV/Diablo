using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private RefTransform _PlayerTransform;

    private NavMeshAgent _Agent;

    private void Awake()
    {
        _Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (_PlayerTransform == null || _PlayerTransform.Value == null)
        {
            return;
        }

        _Agent.SetDestination(_PlayerTransform.Value.position);
    }

}
