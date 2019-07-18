using UnityEngine;
using UnityEngine.Events;

public class OnHealthValueChanged : MonoBehaviour
{
    [SerializeField]
    private HealthValue _HealthValue;

    [SerializeField]
    private UEvent_Float _OnValueChanged;

    private void OnEnable()
    {
        if (_HealthValue != null && _HealthValue.Data != null)
        {
            _HealthValue.Data.Listeners += OnValueChanged;
            OnValueChanged();
        }
    }

    private void OnDisable()
    {
        if (_HealthValue != null)
        {
            _HealthValue.Data.Listeners -= OnValueChanged;
        }
    }

    private void OnValueChanged()
    {
        _OnValueChanged.Invoke(_HealthValue.Data.Value);
    }

    [System.Serializable]
    private class UEvent_Float : UnityEvent<float> { }
}
