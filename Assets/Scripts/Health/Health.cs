using UnityEngine;

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
