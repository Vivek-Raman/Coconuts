using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector3 PositionInGrid => Grid.GetPositionInGrid(this.transform.position);

    public GridSystem Grid { get; set; } = null;

    private PlayerMovement movement = null;
    private PlaceBomb bomber = null;

    private void Awake()
    {
        movement = this.GetComponent<PlayerMovement>();
        bomber = this.GetComponent<PlaceBomb>();
    }

    public void Fire(InputAction.CallbackContext context)
    {
        bomber.PlaceBombAtPosition(PositionInGrid);
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement.MoveInput = context.ReadValue<Vector2>();
    }
}
