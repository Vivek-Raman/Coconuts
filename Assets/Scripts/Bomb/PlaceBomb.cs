using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceBomb : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab = null;

    private Attributes playerAttributes = null;
    private Transform bombParentTransform = null;
    private bool canPlaceBomb = true;

    private void Awake()
    {
        GameObject temp = GameObject.Find("Bombs");
        if (temp == null)
        {
            temp = new GameObject("Bombs");
            temp.transform.position = Vector3.zero;
        }
        bombParentTransform = temp.transform;
        playerAttributes = this.GetComponent<Attributes>();
    }

    public void PlaceBombAtPosition(Vector3 position)
    {
        if (!canPlaceBomb)
        {
            return;
        }
        
        Instantiate(bombPrefab, position, Quaternion.identity, bombParentTransform).TryGetComponent(out Bomb bomb);
        bomb.SetPlayerAndAttributes(this.transform, playerAttributes.BombExplosionRange);
        canPlaceBomb = false;
        Invoke(nameof(Cooldown), playerAttributes.BombCooldown);
    }

    private void Cooldown()
    {
        canPlaceBomb = true;
    }
}
