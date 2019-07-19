using UnityEngine;

/// <summary>
/// Sets a weapon that shots every <see cref="_FireCooldown"/> seconds.
/// </summary>
public class AutomaticWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject _ProjectilePrefab;

    [SerializeField]
    private float _FireCooldown = 0.25f;

    [SerializeField]
    private RefTransform _TargetPosition;

    [SerializeField]
    private float _MinDistance = 5;

    private float _LastFireTime;

    public void Update()
    {
        if (IsAbleToShot() && IsCloseToTarget())
        {
            _LastFireTime = Time.timeSinceLevelLoad;
            Fire();
        }
    }

    protected virtual void Fire()
    {
        Instantiate(_ProjectilePrefab, transform.position, transform.rotation);
    }

    private bool IsAbleToShot()
    {
        return Time.timeSinceLevelLoad >= _LastFireTime + _FireCooldown;
    }

    private bool IsCloseToTarget()
    {
        return Vector3.Distance(this.transform.position, _TargetPosition.Value.position) <= _MinDistance;
    }
}
