using UnityEngine;

[CreateAssetMenu(fileName = "New Grid", menuName = "Grid System")]
public class GridSystem : ScriptableObject
{
    [Range(0.5f, 5f)] public float cellSize;
    public int mapSize;

    private float cellIncrement;
    private float cellSizeReciprocal;

    public GridSystem(float cellSize = 5f, int mapSize = 50)
    {
        this.cellSize = cellSize;
        this.mapSize = mapSize;
        cellIncrement = cellSize * 0.5f;
        cellSizeReciprocal = Mathf.Pow(cellSize, -1f);
    }

    public Vector3 GetPositionInGrid(Vector3 position)
    {
        cellIncrement = cellSize * 0.5f;
        cellSizeReciprocal = Mathf.Pow(cellSize, -1f);
        
        Vector3 positionInGrid = new Vector3(
            GetCentralOrdinateFromPositionOrdinate(position.x),
            0f,
            GetCentralOrdinateFromPositionOrdinate(position.z));

        return positionInGrid;
    }
    
    
    
    private float GetCentralOrdinateFromPositionOrdinate(float ordinate)
    {
        int cellCount = (int) (Mathf.Abs(ordinate) * cellSizeReciprocal);
        return Mathf.Sign(ordinate) * (cellCount * cellSize + cellIncrement);
    }
    
    #region Unity Functions

    private void OnValidate()
    {
        if (cellSize <= 0f)
        {
            cellSize = 0.5f;
        }
    }

    private void Reset()
    {
        cellSize = 5f;
        mapSize = 50;
        cellIncrement = cellSize * 0.5f;     
        cellSizeReciprocal = Mathf.Pow(this.cellSize, -1f);
    }

    #endregion
    
}