using UnityEngine;

public class Midpoint : MonoBehaviour
{
    public PlayersManager manager = null;
    private int playerCount;
    
    private void Update()
    {
        playerCount = manager.players.Count;
        Vector3 midpoint = Vector3.zero;
        
        foreach (Transform player in manager.players)
        {
            midpoint += player.localPosition / playerCount;
        }
        
    }
}