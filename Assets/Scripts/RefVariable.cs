using UnityEngine;

public abstract class RefVariable<T> : GameEvent
{
    [SerializeField]
    private T _Value;

    public T Value
    {
        get => _Value;
        set
        {
            _Value = value;
            Notify();
        }
    }
}
