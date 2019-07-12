using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField]
    private RefFloat _Health;

    private void Start()
    {
        _Health.Value = _Health.MaxValue;
    }

    public override void TakeDamage(float amount) {
        _Health.Value -= amount;

        if (_Health.Value <= _Health.MinValue)
        {
            _Health.Value = _Health.MinValue;
        }
    }
}
