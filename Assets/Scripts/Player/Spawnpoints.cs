using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spawnpoints ", menuName = "Spawnpoints")]
public class Spawnpoints : ScriptableObject
{
    public List<Vector3> playerSpawnpoints;
}