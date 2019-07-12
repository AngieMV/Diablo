using UnityEngine;

public class EnemyHealth : Health
{
    private float _Health;

    [SerializeField]
    private float _MaxValue = 10;

    [SerializeField]
    private float _MinValue = 0;

    private void Start()
    {
        _Health = _MaxValue;
    }

    public override void TakeDamage(float amount)
    {
        _Health -= amount;

        if (_Health <= _MinValue)
        {
            Destroy(gameObject);
        }
    }
}
