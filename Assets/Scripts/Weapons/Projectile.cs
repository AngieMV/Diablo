using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float _Velocity;
    
    [SerializeField]
    private float _LifeTime;

    private Rigidbody _RigidBody;

    private void Start()
    {
        _RigidBody = GetComponent<Rigidbody>();
        _RigidBody.velocity = transform.forward * _Velocity;

        Destroy(gameObject, _LifeTime);
    }
}
