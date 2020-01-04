using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayersManager : MonoBehaviour
{   
    public List<Transform> players = null;
    public Spawnpoints spawns = null;
    [SerializeField] private GridSystem grid = null;
    private int playerIndex = 0;
    private readonly string[] controlSchemes = {"Player 1", "Player 2"};
    
    private void Awake()
    {
        playerIndex = 0;
    }

    public void AddPlayer(PlayerInput input)
    {
        players.Add(input.transform);
        players[playerIndex].position = spawns.playerSpawnpoints[playerIndex];
        input.SwitchCurrentControlScheme(controlSchemes[playerIndex % controlSchemes.Length], Keyboard.current);

        if (grid == null)
        {
            Debug.LogError("Grid not assigned.");
            return;
        }
        
        players[playerIndex].GetComponent<PlayerInputHandler>().Grid = grid;
        players[playerIndex].GetComponent<Attributes>().CellSize = grid.cellSize;
        playerIndex++;
    }

    public void RemovePlayer(PlayerInput input)
    {
        players.Remove(input.transform);
        playerIndex--;
    }
}