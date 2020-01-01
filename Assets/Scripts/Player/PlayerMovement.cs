using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [HideInInspector] public float movementSpeed = 15f;
    
    public Vector2 MoveInput { get; set; } = Vector2.zero;

    private void FixedUpdate()
    {
        this.transform.Translate(Time.deltaTime * movementSpeed * MoveInput.ToVector3(), Space.World);
    }
}
