using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{
    [SerializeField]
    private string _SceneName;

    [SerializeField]
    private bool _LoadOnEnable;

    private void OnEnable()
    {
        if(_LoadOnEnable)
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(_SceneName);
    }
}
