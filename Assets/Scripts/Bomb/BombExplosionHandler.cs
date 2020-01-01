using UnityEngine;

[RequireComponent(typeof(Bomb))]
public class BombExplosionHandler : MonoBehaviour, IExplosionHandler
{
    private Bomb bomb = null;

    private void Awake()
    {
        bomb = this.GetComponent<Bomb>();
    }

    public void OnExplode(Transform bombOwner)
    {
        bomb.layerMask = LayerMask.GetMask("Default", "Wall", "Explodable", "Player");
        bomb.Explode();
    }
}