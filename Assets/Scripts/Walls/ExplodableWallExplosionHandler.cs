using UnityEngine;

public class ExplodableWallExplosionHandler : MonoBehaviour, IExplosionHandler
{
    public void OnExplode()
    {
        Destroy(this.gameObject);
    }
}