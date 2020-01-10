using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float MovementSpeed = 15f;
    
    public Vector2 MoveInput { get; set; } = Vector2.zero;

    private void FixedUpdate()
    {
        Vector3 translation = Time.deltaTime * MovementSpeed * MoveInput.ToVector3();
        this.transform.Translate(translation, Space.World);
    }
}
