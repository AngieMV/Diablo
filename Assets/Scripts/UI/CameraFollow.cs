using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private RefTransform _Transform;

    [SerializeField]
    private float _Smoothing = 10f;

    [SerializeField]
    private Vector3 _Offset = new Vector3(0f, 15f, 0f);

    private Vector3 _PlayerCameraControlOffset = new Vector3();

    private void FixedUpdate()
    {
        if (_Transform == null || _Transform.Value == null)
        {
            return;
        }

        Vector3 targetPosition = _Transform.Value.position + _Offset + _PlayerCameraControlOffset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, _Smoothing * Time.deltaTime);
    }
}