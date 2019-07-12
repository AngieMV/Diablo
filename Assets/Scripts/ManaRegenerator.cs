using UnityEngine;

public class ManaRegenerator : MonoBehaviour
{
    [SerializeField]
    private RefFloat _Mana;

    [SerializeField]
    private float _Amount;

    [SerializeField]
    private float _Rate;

    private void Start()
    {
        _Mana.Value = _Mana.MaxValue;
        InvokeRepeating("Regenerate", _Rate, _Rate);
    }

    private void Regenerate()
    {
        if (_Mana.Value >= _Mana.MaxValue)
        {
            _Mana.Value = _Mana.MaxValue;
            return;
        }

        _Mana.Value += _Amount;
    }

}
