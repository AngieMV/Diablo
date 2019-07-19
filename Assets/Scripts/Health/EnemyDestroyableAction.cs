/// <summary>
/// Action to perform when the enemy is destroyed.
/// </summary>
public class EnemyDestroyableAction : DestroyableAction
{
    public override void DestroyObject()
    {
        Destroy(gameObject);
    }    
}
