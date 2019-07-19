using UnityEngine;

/// <summary>
/// Encapsulates the mechanism to keep track of health data for the units.
/// </summary>
public class HealthValue : MonoBehaviour
{
    private RefFloat _RefFloat;

    [SerializeField]
    private float _MaxValue;

    [SerializeField]
    private float _MinValue;

    public RefFloat Data { get => _RefFloat; set => _RefFloat = value; }

    private void OnEnable()
    {
        _RefFloat = ScriptableObject.CreateInstance<RefFloat>();
        _RefFloat.MaxValue = _MaxValue;
        _RefFloat.MinValue = _MinValue;
        _RefFloat.Value = _MaxValue; 
    }

}
