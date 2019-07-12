using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _Enemy;

    [SerializeField]
    private float _SpawnCooldown = 6f;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, _SpawnCooldown);
    }

    private void SpawnEnemy()
    {
        Instantiate(_Enemy, transform.position, transform.rotation);
    }
}