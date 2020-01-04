using System;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    private const float MinimumBombExplosionRange = 1f;
    private const float MaximumBombExplosionRange = 3f;
    
    [SerializeField] private float bombCooldown = 3f;

    private float bombExplosionRangeInCells;

    public float CellSize { get; set; } = 5f;

    
    private void Awake()
    {
        BombExplosionRangeInCells = 1f;
    }
    
    public float BombCooldown
    {
        get => bombCooldown;
        set => bombCooldown = (value <= 1f) ? 1f : value;
    }

    public float BombExplosionRange { get; private set; } = 5f;

    public float BombExplosionRangeInCells
    {
        get => bombExplosionRangeInCells;
        set
        {
            bombExplosionRangeInCells = Mathf.Clamp(value, 
                MinimumBombExplosionRange, 
                MaximumBombExplosionRange);
            BombExplosionRange = DistanceFromCellCount(BombExplosionRangeInCells);
        }
    }

    private float DistanceFromCellCount(float cells)
    {
        return cells * CellSize;
    }
}