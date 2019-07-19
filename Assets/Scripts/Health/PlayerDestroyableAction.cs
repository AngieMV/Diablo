/// <summary>
/// Action to perform when the player is destroyed.
/// </summary>
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
