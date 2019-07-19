using UnityEngine;

/// <summary>
/// Encapsulates <see cref="HealthValue"/> with unit's health data, and a <see cref="DestroyableAction"/> that defines how to perform when destroying this unit.
/// </summary>
public class Health : MonoBehaviour
{
    [SerializeField]
    private HealthValue _Health;

    [SerializeField]
    public DestroyableAction _DestroyAction;

    public void TakeDamage(float amount)
    {
        _Health.Data.Value -= amount;

        if (_Health == null || _Health.Data.Value <= _Health.Data.MinValue)
        {
            _DestroyAction.DestroyObject();
        }
    }
}
