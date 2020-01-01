using UnityEngine;

public class Attributes : MonoBehaviour
{
    [SerializeField] private float bombCooldown = 3f;
    [SerializeField] private float bombExplosionRange = 3f;

    // movement speed?
    
    private float cellSize = 0.5f;
    
    private void Awake()
    {
        // assigns cellSize from GridSystem object
        if (this.TryGetComponent(out PlayerInputHandler inputHandler))
        {
            cellSize = inputHandler.System.cellSize;
        }
    }

    public float BombCooldown
    {
        get => bombCooldown;
        set => bombCooldown = (value <= 1f) ? 1f : value;
    }

    public float BombExplosionRange
    {
        get => bombExplosionRange;
        set => bombExplosionRange = Mathf.Clamp(value, 
            DistanceFromCellCount(1f), 
            DistanceFromCellCount(4f));
    }

    private float DistanceFromCellCount(float cells)
    {
        return (cells + 0.5f) * cellSize;
    }

}
