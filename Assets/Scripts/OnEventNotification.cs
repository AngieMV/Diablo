using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class OnEventNotification : MonoBehaviour
{
    [SerializeField]
    private GameEvent _GameEvent;

    [SerializeField]
    private UnityEvent _OnEventTriggered;

    private void OnEnable()
    {
        _GameEvent.Listeners += OnEventTriggered;
    }

    private void OnDisable()
    {
        _GameEvent.Listeners -= OnEventTriggered;
    }

    [Button]
    private void OnEventTriggered()
    {
        _OnEventTriggered.Invoke();
    }

}
