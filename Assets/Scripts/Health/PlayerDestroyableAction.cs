
public class PlayerDestroyableAction : DestroyableAction
{
    private LoadSceneByName _LoadScene;

    private void Start()
    {
        _LoadScene = GetComponent<LoadSceneByName>();
    }

    public override void DestroyObject()
    {
        _LoadScene.LoadScene();
    }
}
