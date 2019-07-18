using UnityEngine;
using UnityEngine.UI;

public class BarUpdater : MonoBehaviour
{
    private Canvas _Canvas;

    [SerializeField]
    private GameObject _Bar;

    [SerializeField]
    private Vector3 _Offset;

    private Image _Image;

    private void Start()
    {
        _Canvas = FindObjectOfType<Canvas>();
        _Image = Instantiate(_Bar, _Canvas.transform).GetComponent<Image>();
    }

    private void Update()
    {
        _Image.transform.position = Camera.main.WorldToScreenPoint(transform.position + _Offset);
    }
}
