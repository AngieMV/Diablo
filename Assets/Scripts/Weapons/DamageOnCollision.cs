using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    [SerializeField]
    private int _Damage = 1; 

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Health>()?.TakeDamage(_Damage);
        Destroy(gameObject);
    }

}
