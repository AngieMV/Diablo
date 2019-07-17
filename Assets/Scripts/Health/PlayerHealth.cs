using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField]
    private RefFloat _Health;

    private LoadSceneByName _LoadScene;

    private void Start()
    {
        _Health.Value = _Health.MaxValue;
        _LoadScene = GetComponent<LoadSceneByName>();
    }

    public override void TakeDamage(float amount) {
        _Health.Value -= amount;

        if (_Health.Value <= _Health.MinValue)
        {
            _LoadScene.LoadScene();
        }
    }
}
