using UnityEngine;
/// <summary>
/// Sets a weapon that shots if there is mana available.
/// </summary>
public class AssaultWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject _ProjectilePrefab;

    private Camera _Camera;

    [SerializeField]
    private RefTransform _Parent;

    [SerializeField]
    private RefFloat _Mana;

    [SerializeField]
    private float _FiringCost = 5;

    private void Awake()
    {
        _Camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = _Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                _Parent.Value.rotation = Quaternion.LookRotation(hit.point - _Parent.Value.position);
                TryToFire();
            }
        }
    }

    private void TryToFire()
    {
        if (_Mana.Value >= _FiringCost)
        {
            Fire();
            _Mana.Value -= _FiringCost;
        }
    }

    protected virtual void Fire()
    {
        Instantiate(_ProjectilePrefab, transform.position, transform.rotation);
    }
}
