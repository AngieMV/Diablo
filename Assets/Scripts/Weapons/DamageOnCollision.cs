using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    [SerializeField]
    private float _Damage = 0.01f; 

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Health>()?.TakeDamage(_Damage);
        Destroy(gameObject);
    }

}
