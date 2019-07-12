using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class OnFloatValueChanged : MonoBehaviour
{
    [Required]
    [SerializeField]
    private RefFloat _RefFloat;

    [SerializeField]
    private UEvent_Float _OnValueChanged;

    private void OnEnable()
    {
        _RefFloat.Listeners += OnValueChanged;
        OnValueChanged();
    }

    private void OnDisable()
    {
        _RefFloat.Listeners -= OnValueChanged;
    }

    private void OnValueChanged()
    {
        _OnValueChanged.Invoke(_RefFloat.Value);
    }

    [System.Serializable]
    private class UEvent_Float : UnityEvent<float> { }
}
