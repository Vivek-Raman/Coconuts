using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    
    public Vector2 MoveInput { get; set; } = Vector2.zero;

    private void Update()
    {
        this.transform.Translate(Time.deltaTime * movementSpeed * MoveInput.ToVector3(), Space.World);
    }
}
