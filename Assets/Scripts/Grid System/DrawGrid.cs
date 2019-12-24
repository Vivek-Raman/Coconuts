using UnityEngine;

[ExecuteInEditMode]
public class DrawGrid : MonoBehaviour
{
    public GridSystem gridSystem = null;
    [SerializeField] private float gridY = 0.5f;
    [SerializeField] private bool drawGrid = false;
    private float boundUpLeft;
    private float boundDownRight;

    private void OnValidate()
    {
        boundUpLeft = gridSystem.mapSize * -0.5f;
        boundDownRight = gridSystem.mapSize * 0.5f;
    }

    private void OnDrawGizmos()
    {
        if (!drawGrid)
        {
            return;
        }

        Vector3 fromH = new Vector3(boundUpLeft, gridY, boundUpLeft);
        Vector3 toH = new Vector3(boundUpLeft, gridY, boundDownRight);
        Vector3 fromV = new Vector3(boundUpLeft, gridY, boundUpLeft);
        Vector3 toV = new Vector3(boundDownRight, gridY, boundUpLeft);

        for (float i = boundUpLeft; i <= boundDownRight; i += gridSystem.cellSize)
        {
            if (gridSystem.cellSize <= 0f)
            {
                Debug.Log("cell size invalid");
                return;
            }
            fromH.x = toH.x = fromV.z = toV.z = i;
            Gizmos.DrawLine(fromH, toH);
            Gizmos.DrawLine(fromV, toV);
        }
    }
}