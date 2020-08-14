using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // use callbacks on players (score manager)
    private void Awake()
    {
        Health.onHealthModified += HandleDamage;
    }

    private void OnDestroy()
    {
        Health.onHealthModified -= HandleDamage;
    }

    private void HandleDamage(Transform damageSource, Transform damageTarget)
    {
        Debug.Log(damageSource + " dealt damage to " + damageTarget);
    }
}