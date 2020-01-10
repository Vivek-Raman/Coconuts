using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Modifier Table")]
public class ModifierTable : ScriptableObject
{
    public List<GameObject> modifiers = new List<GameObject>();

    public GameObject GetRandomModifier()
    {
        return modifiers[Random.Range(0, modifiers.Count - 1)];
    }
}