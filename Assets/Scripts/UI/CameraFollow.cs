using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private RefTransform _Transform;

    [SerializeField]
    private float _Smoothing = 10f;

    [SerializeField]
    private Vector3 offset = new Vector3(0f, 12f, 0f);

    private Vector3 playerCameraControlOffset = new Vector3();

    private void FixedUpdate()
    {
        if (this._Transform == null || this._Transform.Value == null)
        {
            return;
        }

        Vector3 targetPosition = this._Transform.Value.position + this.offset + this.playerCameraControlOffset;
        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, this._Smoothing * Time.deltaTime);
    }
}