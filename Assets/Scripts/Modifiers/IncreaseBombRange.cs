using UnityEngine;

public class IncreaseBombRange : Modifier
{
    [SerializeField] private int rangeIncrement = 1;
    
    protected override void Modify()
    {
        Debug.Log("picked up");
        player.BombExplosionRangeInCells += rangeIncrement;
    }
}
