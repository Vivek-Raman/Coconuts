using System;
using UnityEngine;

public class PlayerExplosionHandler : MonoBehaviour, IExplosionHandler
{
    private Health health;

    private void Awake()
    {
        health = this.GetComponent<Health>();
    }

    public void OnExplode(Transform bombOwner)
    {
        health.ModifyHealth(-1, bombOwner);
    }
}