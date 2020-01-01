using UnityEngine;

public class ExplodableWallExplosionHandler : MonoBehaviour, IExplosionHandler
{
    public void OnExplode(Transform bombOwner)
    {
        Destroy(this.gameObject);
    }
}