using System;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/GameEvent", fileName = "Event_")]
public class GameEvent : ScriptableObject
{
    public event Action Listeners;

    [Button]
    public void Notify()
    {
        Listeners?.Invoke();
    }
}