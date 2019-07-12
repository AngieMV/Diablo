using UnityEngine;

public class SetRefTransform : MonoBehaviour
{
    [SerializeField]
    private RefTransform _RefTransform;

    private void OnEnable()
    {
        _RefTransform.Value = transform;
    }
}
